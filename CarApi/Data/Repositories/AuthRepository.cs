using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Extensions.CognitoAuthentication;
using CarApi.DTOs;
using CarApi.Models;
using System.Net;

namespace CarApi.Data.Repositories
{
    public interface IAuthRepository
    {
        void ListUserPoolsAsync();
        Task<Guid> SignUpAsync(SignUpDto signUpDto);
        Task AddUser(SignUpDto signUpDto, Guid userSub);
        Task<InitiateAuthResponse> InitiateAuthAsync(LogInDto logInDto);
        Task<bool> ConfirmSignupAsync(string authCode, string userId);
    }

    public class AuthRepository: IAuthRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IAmazonCognitoIdentityProvider _cognitoService;
        private readonly string clientId;
        private readonly CognitoUserPool _userPool;

        public AuthRepository(AppDbContext dbContext,
            IAmazonCognitoIdentityProvider cognitoService, 
            CognitoUserPool userPool,
            IConfiguration configuration) 
        {
            _userPool = userPool;
            _dbContext = dbContext;
            _cognitoService = cognitoService;
            clientId = configuration.GetValue<string>("AWS:AppClientId");
        }

        public async void ListUserPoolsAsync()
        {
            var userPools = new List<UserPoolDescriptionType>();

            var userPoolsPaginator = _cognitoService.Paginators.ListUserPools(new ListUserPoolsRequest());

            await foreach (var response in userPoolsPaginator.Responses)
            {
                userPools.AddRange(response.UserPools);
            }
            Console.WriteLine(userPools);
            //return userPools;
        }

        public async Task<Guid> SignUpAsync( SignUpDto signUpDto)
        {
            var country = _dbContext.Countries
                                .Where(x => x.IdCountry == signUpDto.id_country)
                                .Select( x => x.Name);

            var userAttrsList = new List<AttributeType>() {
                new AttributeType { Name = "email", Value = signUpDto.email, },
                new AttributeType { Name = "custom:city", Value = signUpDto.city, },
                new AttributeType { Name = "custom:country", Value = country.ToString(), },
                new AttributeType { Name = "custom:first_name", Value = signUpDto.firstName, },
                new AttributeType { Name = "custom:last_name", Value = signUpDto.lastName, },
                new AttributeType { Name = "custom:postal_code", Value =   signUpDto.postalCode.ToString(), },
                new AttributeType { Name = "custom:telephone", Value = signUpDto.telephone.ToString(), },
                new AttributeType { Name = "custom:username", Value = signUpDto.userName, },
                new AttributeType { Name = "address", Value = signUpDto.address, },
                
            };

            
            //Email is the same that username
            var signUpRequest = new SignUpRequest
            {
                UserAttributes = userAttrsList,
                Username = signUpDto.email,
                ClientId = clientId,
                Password = signUpDto.password,
            };

            var response = await _cognitoService.SignUpAsync(signUpRequest);
            string userSub = response.UserSub;
            
            return new Guid(userSub);

            //return response.HttpStatusCode == HttpStatusCode.OK;
        }

        public async Task<bool> ConfirmSignupAsync(string authCode, string userId)
        {
            var signUpRequest = new ConfirmSignUpRequest
            {
                ClientId = clientId,
                ConfirmationCode = authCode,
                Username = userId,
            };

            var response = await _cognitoService.ConfirmSignUpAsync(signUpRequest);
            
            if (response.HttpStatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine($"User was confirmed");
                return true;
            }
            return false;
        }

        public async Task AddUser(SignUpDto signUpDto, Guid userSub)
        {
            User user = new User
            {
                IdUser = userSub,
                Email = signUpDto.email,
                Username = signUpDto.userName,
                FirstName = signUpDto.firstName,
                LastName = signUpDto.lastName,
                UserAddress = new UserAddress
                {
                    Address = signUpDto.address,
                    City = signUpDto.city,
                    PostalCode = signUpDto.postalCode,
                    Telephone = signUpDto.telephone,
                    IdCountry = signUpDto.id_country,
                }
            };

            _dbContext.Add(user);
            await _dbContext.SaveChangesAsync();

        }

        

        public async Task<InitiateAuthResponse> InitiateAuthAsync(LogInDto logInDto)
        {
            var authParameters = new Dictionary<string, string>();
            authParameters.Add("USERNAME", logInDto.userName);
            authParameters.Add("PASSWORD", logInDto.password);

            var authRequest = new InitiateAuthRequest

            {
                ClientId = clientId,
                AuthParameters = authParameters,
                AuthFlow = AuthFlowType.USER_PASSWORD_AUTH,
            };

            var response = await _cognitoService.InitiateAuthAsync(authRequest);
            Console.WriteLine($"Result Challenge is : {response.ChallengeName}");

            return response;
        }


    }
}

using CarApi.Data.Repositories;
using CarApi.DTOs;
using Microsoft.AspNetCore.Mvc;
using ServiceStack;
using System.Collections;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarApi.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository){
            _authRepository = authRepository;
        }

        
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUpDto signUpDto)
        {
            try
            {
                Guid userSub = await _authRepository.SignUpAsync(signUpDto);

                await _authRepository.AddUser(signUpDto, userSub);

                return Ok("User successfully registered");

            }catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }

        [HttpPost("ConfirmUser")]
        public async Task<IActionResult> ConfirmUser(string authCode, string userId)
        {
            try
            {
                await _authRepository.ConfirmSignupAsync(authCode, userId);


                return Ok("User was confirmed");

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }

        [HttpPost("LogIn")]
        public async Task<IActionResult> LogIn([FromBody] LogInDto logInDto)
        {
            try
            {
                var res = await _authRepository.InitiateAuthAsync(logInDto);
                
                //return new HttpResult( HttpStatusCode.Accepted)'
                return Ok(res.AuthenticationResult);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }

        // GET api/<AuthController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<AuthController>
        
    }
}

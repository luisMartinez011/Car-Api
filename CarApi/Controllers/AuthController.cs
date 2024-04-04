using CarApi.Data.Repositories;
using CarApi.DTOs;
using CarApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceStack;
using ServiceStack.Web;
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

        /// <summary>
        /// SignUp a user. 
        /// 
        /// </summary>
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUpDto signUpDto)
        {
            try
            {
                Guid userId = await _authRepository.SignUpAsync(signUpDto);
                await _authRepository.AddUser(signUpDto, userId);

                string message = "User succesfully created";
                object response = new { userId,
                    message
                    };
                return Ok(response);

            }catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }

        /// <summary>
        /// Confirm User with authCode. The authcode is sent via email
        /// 
        /// </summary>
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

        /// <summary>
        /// Login a user who is already confirmed.
        /// 
        /// </summary>
        [HttpPost("LogIn")]
        public async Task<IActionResult> LogIn([FromBody] LogInDto logInDto)
        {
            try
            {
                var res = await _authRepository.InitiateAuthAsync(logInDto);

                var userId = await _authRepository.GetUserId(logInDto.email);

                var token = res.AuthenticationResult.AccessToken;
                object response = new
                {
                    userId,
                    token
                };
                //return new HttpResult( HttpStatusCode.Accepted)'
                return Ok(response);

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

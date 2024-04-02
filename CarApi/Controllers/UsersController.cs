using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarApi.Data;
using CarApi.Models;
using CarApi.Middlewares;
using Microsoft.AspNetCore.Authorization;

namespace CarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }


        // GET: api/Users/5
        /// <summary>
        /// Get the user by idUser. Authentication required.
        /// 
        /// </summary>
        [HttpGet("{idUser}")]
        [Authorize]
        [ClaimAuthorizationFilter("username", "idUser")]
        public async Task<ActionResult<User>> GetUser(Guid idUser)
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            var user = await _context.Users
                //.FindAsync(idUser).
                .Include(u => u.UserAddress)
                .FirstOrDefaultAsync(u => u.IdUser == idUser);
                //;

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        

    }
}

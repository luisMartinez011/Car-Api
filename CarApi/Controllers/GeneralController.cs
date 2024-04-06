using CarApi.Data;
using CarApi.Middlewares;
using CarApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GeneralController(AppDbContext context)
        {
            _context = context;
        }
       

        /// <summary>
        /// Get the user by idUser. Authentication required.
        /// 
        /// </summary>
        [HttpGet("user/{idUser}")]
        [Authorize]
        
        [ClaimAuthorizationFilter("username", "idUser")]
        public async Task<ActionResult<User>> GetUser(Guid idUser)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users
                .Include(u => u.UserAddress)
                .FirstOrDefaultAsync(u => u.IdUser == idUser);
            

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        /// <summary>
        /// Get list of countries. 
        /// 
        /// </summary>
        [HttpGet("countries")]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
        {
            if (_context.Cars == null)
            {
                return NotFound();
            }
            return await _context.Countries
                //.IgnoreAutoIncludes()
                .ToListAsync();
        }

        /// <summary>
        /// Get list of Brands. 
        /// 
        /// </summary>
        [HttpGet("brands")]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            if (_context.Cars == null)
            {
                return NotFound();
            }
            return await _context.Brands
                .Include(b => b.Country)
                .ToListAsync();
        }
    }
}

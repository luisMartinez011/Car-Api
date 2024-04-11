using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarApi.Data;
using CarApi.Models;
using CarApi.DTOs;
using CarApi.Middlewares;
using Microsoft.AspNetCore.Authorization;

namespace CarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AppointmentsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Appointments
        /// <summary>
        /// Get the appointments by idUser. Authentication required.
        /// 
        /// </summary>
        [HttpGet("{idUser}")]
        [Authorize]
        [ClaimAuthorizationFilter("username", "idUser")]
        public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointments(Guid idUser)
        {
          if (_context.Appointments == null)
          {
              return NotFound();
          }
            return await _context.Appointments
                .Where(x => x.IdUser== idUser)
                .Include(x => x.Car)
                .ToListAsync();
        }

        /// <summary>
        /// Post the appointment by idUser, idCar and Date. Authentication required.
        /// </summary>
        [HttpPost("{idUser}")]
        [Authorize]
        [ClaimAuthorizationFilter("username", "idUser")]
        public async Task<IActionResult> PostAppointment([FromBody] AppointmentDto appointmentDto, Guid idUser)
        {
            if (_context.Appointments == null)
            {
                return Problem("Entity set 'AppDbContext.Appointments'  is null.");
            }

            Appointment appointment = new Appointment
            {
                Date = appointmentDto.date,
                IdUser = idUser,
                IdCar = appointmentDto.idCar,
            };

            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            return Ok("Appointment created");

        }

        

    }
}

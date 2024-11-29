using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.DTOs;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{   
    [Route("api/v1.0/ticket")]
    [ApiController]
    public class TicketController : ControllerBase
        {
            private readonly AirlineDBContext _context;

            public TicketController(AirlineDBContext context)
            {
                _context = context;
            }

            [HttpPost("buyTicket")]
        public async Task<IActionResult> buyTicket([FromBody] TicketDto ticketDto){
            var flight = await _context.Flights.FirstOrDefaultAsync(flight => flight.Id == ticketDto.FlightId);
            if (flight == null)
            {
                return NotFound(new {status = "Flight not found"});
            }
            var customer = await _context.Passangers.AnyAsync(p => p.Id == ticketDto.PassangerId);
            if (!customer)
            {
                return NotFound(new {status = "passenger"});
            }
            flight.AvailableSeats--;
            _context.Update(flight);
            var ticketModel = ticketDto.toticketDto();
            await _context.AddAsync(ticketModel);
            await _context.SaveChangesAsync();
            return Ok(new {Status =  "OK", Message = "ticket bought"});
        }


        [HttpPost("checkIn")]
        public async Task<ActionResult> CheckIn([FromBody] CheckinDto checkinDto){
            var ticket = await _context.Tickets.FirstOrDefaultAsync(t => t.Id == checkinDto.Id);
            if (ticket == null)
            {
                return NotFound(new {status = "ticket not found"});
            }
            if(ticket.CheckedIn){
                return BadRequest(new {status = "ticket already checked in"});
            }
            ticket.CheckedIn= true;
            _context.Tickets.Update(ticket);
            await _context.SaveChangesAsync();
            return Ok();
        }


    }
}
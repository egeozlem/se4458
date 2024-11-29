using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.DTOs;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/flight")]
    [ApiController]
    public class FlightController: ControllerBase
    {
        private readonly AirlineDBContext _context;
        public FlightController(AirlineDBContext context)
        {
            _context = context;
        }

        [HttpGet("querryFlight")]
        // TODO paging
        public async Task<IActionResult> QuerryFlight(int page = 1, int pageSize =3 ){
            var totalFlights = await _context.Flights.CountAsync(Flight=>Flight.AvailableSeats > 0);
            var availableFlights = await _context.Flights.Where(Flight=>Flight.AvailableSeats > 0)
                                    .Skip((page-1)*pageSize).Take(pageSize)
                                    .ToListAsync();
            var availableFlightsDto = availableFlights.Select(s => s.toFlightDto());
            return Ok(availableFlightsDto);
        }

        [HttpPost("insertFlight")]
        // TODO  auth
        public async Task <ActionResult> InsertFlight([FromBody] FlightPostDto flightPostDto){
            var flightModel = flightPostDto.flightPostDto();
            if (await _context.Flights.ContainsAsync(flightModel))
            {
                BadRequest(new {status = "Flight already exists"});
            }
            await _context.Flights.AddAsync(flightModel);
            await _context.SaveChangesAsync();
            return Ok(new {Status =  "OK", Message = "Flight inserted"});
        }


        [HttpGet("AdminQuerry")]
        // TODO paging & auth
        public async Task<IActionResult> FlightsWithCapacity(int page= 1, int pageSize = 3){
           var totalFlights = await _context.Flights.CountAsync(Flight=>Flight.AvailableSeats > 0);
            var availableFlights = await _context.Flights.Where(Flight=>Flight.AvailableSeats > 0)
                                    .Skip((page-1)*pageSize).Take(pageSize)
                                    .ToListAsync();
            var availableFlightsDto = availableFlights.Select(s => s.toFlightDto());
            return Ok(availableFlightsDto);
        }

    
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs;
using api.Models;

namespace api.Mappers
{
    public static class FlightMapper
    {
        public static FlightDto toFlightDto(this Flight flightModel){
            return new FlightDto{
                Id = flightModel.Id,
                To = flightModel.To,
                Date = flightModel.Date,
                From = flightModel.From,
                AvailableSeats = flightModel.AvailableSeats
            };
        }

        public static Flight flightPostDto(this FlightPostDto flightModel){
            return new Flight{
                To = flightModel.To,
                Date = flightModel.Date,
                From = flightModel.From,
                Capacity = flightModel.Capacity
            };
        }
    }
}
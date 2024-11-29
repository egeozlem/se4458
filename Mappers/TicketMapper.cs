using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs;
using api.Models;

namespace api.Mappers
{
    public static class TicketMapper
    {
        public static Ticket toticketDto(this TicketDto ticketModel ){
            return new Ticket{
                PassangerId = ticketModel.PassangerId,
                PassangerName = ticketModel.PassangerName,
                FlightId = ticketModel.FlightId,
            };

        }

        public static Ticket toCheckinDto(this CheckinDto ticketModel ){
            return new Ticket{
                Id = ticketModel.Id,
            };

        }
    }
}
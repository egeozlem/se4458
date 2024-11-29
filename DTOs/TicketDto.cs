using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs
{
    public class TicketDto
    {
        public int PassangerId { get; set; }
        public int FlightId { get; set;}
        public string PassangerName { get; set; }
        
        
    }
}
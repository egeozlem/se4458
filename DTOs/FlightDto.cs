using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs
{
    public class FlightDto
    {
        public int Id {get; set;}
        public string From {get; set;}
        public string To {get; set;}
        public DateTime Date {get; set;}
        public int AvailableSeats {get; set;}
      
        }
}
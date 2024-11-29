using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs
{
    public class FlightPostDto
    {
        public string From {get; set;}
        public string To {get; set;}
        public DateTime Date {get; set;}
        public int Capacity {get; set;}
    }
}
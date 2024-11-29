using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Flight
    {
        public int Id {get; set;}
        public string From {get; set;}
        public string To {get; set;}
        public DateTime Date {get; set;}
        public int Capacity {get; set;}
        public int AvailableSeats{get; set;}
        public ICollection<Ticket> Tickets { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int FlightId { get; set;}
        public Flight Flight { get; set; }
        public string PassangerName { get; set; }
        public bool CheckedIn { get; set; }
        public int PassangerId { get; set; }
    }
}
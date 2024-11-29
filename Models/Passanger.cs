using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Passanger
    {
        public int Id { get; set; }
        public string PassangerName { get; set; }  
        public ICollection<Ticket> Tickets { get; set; }
        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class AirlineDBContext: DbContext
    {
        public AirlineDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }

        public DbSet<Ticket> Tickets {get; set;}
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passanger> Passangers { get; set; }
    }
}
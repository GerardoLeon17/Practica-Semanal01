using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class EventDbContext : DbContext
    {
        public EventDbContext():base ("MyConnection")
            {
                
            }

        public DbSet<Event> Events { get; set; }
        public DbSet<City> Citys { get; set; }
    }
}
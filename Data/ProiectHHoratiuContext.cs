using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectHHoratiu.Models;

namespace ProiectHHoratiu.Data
{
    public class ProiectHHoratiuContext : DbContext
    {
        public ProiectHHoratiuContext (DbContextOptions<ProiectHHoratiuContext> options)
            : base(options)
        {
        }

        public DbSet<ProiectHHoratiu.Models.Person> Person { get; set; }
    }
}

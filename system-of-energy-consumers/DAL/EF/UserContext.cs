using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class UserContext
         : DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<House> house { get; set; }
        public DbSet<OperationalIndicator> operationalIndicators { get; set; }
        public DbSet<EnergyIndicator> energyIndicators { get; set; }
        
        public UserContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}

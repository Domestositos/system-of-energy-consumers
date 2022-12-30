using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class UserContext
         : DbContext
    {
        public DbSet<User> Phones { get; set; }
        public DbSet<House> Orders { get; set; }
​
        public OSBBContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}

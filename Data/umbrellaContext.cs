using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using umbrella.Models;

namespace umbrella.Models
{
    public class umbrellaContext : DbContext
    {
        public umbrellaContext (DbContextOptions<umbrellaContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Advertisement> Advertisement { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}

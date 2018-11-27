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

        public DbSet<umbrella.Models.User> User { get; set; }

        public DbSet<umbrella.Models.Advertisement> Advertisement { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreLearn.Models
{
    public class HelloWorldDbContext : DbContext
    {
        public HelloWorldDbContext(DbContextOptions<HelloWorldDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empolyee> Empolyees { get; set; }
    }
}

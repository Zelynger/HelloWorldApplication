using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldApplication.Models
{
    public class HelloWorldApplicationContext : DbContext
    {
        public HelloWorldApplicationContext (DbContextOptions<HelloWorldApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<HelloWorldApplication.Models.User> User { get; set; }
    }
}

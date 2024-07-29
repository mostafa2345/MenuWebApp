using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstOne.Models;

namespace FirstOne.Data
{
    public class FirstOneContext : DbContext
    {
        public FirstOneContext (DbContextOptions<FirstOneContext> options)
            : base(options)
        {
        }

        public DbSet<FirstOne.Models.Movie> Movie { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheNaturalTouch.Models;

namespace TheNaturalTouch.Data
{
    public class TheNaturalTouchContext : DbContext
    {
        public TheNaturalTouchContext (DbContextOptions<TheNaturalTouchContext> options)
            : base(options)
        {
        }

        public DbSet<TheNaturalTouch.Models.Product> Product { get; set; } = default!;
    }
}

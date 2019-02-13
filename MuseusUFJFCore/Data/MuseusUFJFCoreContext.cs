using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MuseusUFJFCore.Models
{
    public class MuseusUFJFCoreContext : DbContext
    {
        public MuseusUFJFCoreContext (DbContextOptions<MuseusUFJFCoreContext> options)
            : base(options)
        {
        }

        public DbSet<MuseusUFJFCore.Models.Unit> Unit { get; set; }
    }
}

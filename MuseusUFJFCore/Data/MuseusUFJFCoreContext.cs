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

        public DbSet<Unit> Unit { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Collection> Collection { get; set; }
    }
}

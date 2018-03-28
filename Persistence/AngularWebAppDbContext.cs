using AngularWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWebApp.Persistence
{
    public class AngularWebAppDbContext :DbContext
    {
        public AngularWebAppDbContext(DbContextOptions<AngularWebAppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}

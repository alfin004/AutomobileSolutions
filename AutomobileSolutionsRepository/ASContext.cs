using AutomobileSolutionsRepository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomobileSolutionsRepository
{
    public class ASContext : DbContext
    {
        public ASContext(DbContextOptions<ASContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<CarModels> CarModel { get; set; }
        public DbSet<SparePartModel> SparePartModels { get; set; }
    }
}

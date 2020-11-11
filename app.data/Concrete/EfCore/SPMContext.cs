using app.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace app.data.Concrete.EfCore
{
   public  class SPMContext:DbContext
    {
        public DbSet<Portfolio> portfolios { get; set; }
        public DbSet<PortfolioItem> portfolioItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=appDb");
        }
    }
}

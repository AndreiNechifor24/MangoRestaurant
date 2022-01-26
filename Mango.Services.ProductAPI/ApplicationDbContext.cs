using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mango.Services.ProductAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        #region DBSets

            public DbSet<Product> Products { get; set; }
            public DbSet<Category> ProductCategories { get; set; }

        #endregion

    }
}

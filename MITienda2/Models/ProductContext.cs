using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MITienda2.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(): base("MiTienda2")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
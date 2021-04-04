using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEcommerce.Models;

namespace WSEcommerce.Data
{
    public class WSEcommerceDbContext : DbContext
    {
        public WSEcommerceDbContext(DbContextOptions<WSEcommerceDbContext> options)
               : base(options)
        {
        }

        public DbSet<Products> Products {get; set;}
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<ProjectRequest> ProjectRequests { get; set; }
        

    }

}

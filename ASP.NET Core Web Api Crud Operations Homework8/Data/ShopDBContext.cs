using ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Web_Api_Crud_Operations_Homework8.Data
{
    public class ShopDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public ShopDBContext(DbContextOptions<ShopDBContext> options)
            : base(options)
        {

        }

    }
}

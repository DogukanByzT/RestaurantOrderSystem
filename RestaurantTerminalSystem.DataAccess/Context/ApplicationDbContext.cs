using Microsoft.EntityFrameworkCore;
using RestaurantTerminalSystem.Entities.Entities;
using System;

namespace RestaurantTerminalSystem.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }  // public erişim
        public DbSet<Product> Products { get; set; }  // public erişim
        public DbSet<Employee> Employees { get; set; }  // public erişim
        public DbSet<Order> Orders { get; set; }  // public erişim
        public DbSet<OrderDetail> OrderDetails { get; set; }  // public erişim

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("***");
        }
    }
}

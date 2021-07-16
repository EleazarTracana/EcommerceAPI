using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace Ecommerce.Domain
{
    public class ShoppingDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ShoppingDbContext(): base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=TestDatabase.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ORDER
            modelBuilder.Entity<Order>(b =>
            {
                b.HasKey(p => p.Id);
                b.HasMany(p => p.OrderDetails);
                b.HasOne(p => p.Customer);
                b.HasOne(p => p.Seller);
            });
            //ORDER DETAIL
            modelBuilder.Entity<OrderDetail>(b =>
            {
                b.HasKey(p => p.Id);
                b.HasOne(p => p.Order);
            });

            //CUSTOMER
            modelBuilder.Entity<Customer>(b =>
            {
                b.HasKey(p => p.Id);
            });

            //PAYMENTS
            modelBuilder.Entity<Payment>(b =>
            {
                b.HasKey(p => p.Id);
            });

            //TRANSACTION
            modelBuilder.Entity<Transaction>(b =>
            {
                b.HasKey(p => p.Id);
                b.HasOne(p => p.Payment);
                b.HasOne(p => p.Order);
            });

            //CATEGORY 
            modelBuilder.Entity<Category>(b =>
            {
                b.HasKey(p => p.Id);
                b.HasMany(p => p.Products);
            });

            //SELLER
            modelBuilder.Entity<Seller>(b =>
            {
                b.HasKey(p => p.Id);
                b.HasMany(p => p.Orders);
            });

            //PRODUCT
            modelBuilder.Entity<Product>(b =>
            {
                b.HasKey(p => p.Id);
                b.HasOne(p => p.Category);
            });

            //STOCK
            modelBuilder.Entity<Stock>(b =>
            {
                b.HasKey(p => p.Id);
                b.HasOne(p => p.Office);
                b.HasOne(p => p.Product);

            });
        }
    }
}

using Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Presistance
{
    public class DBContextApplication : DbContext
    {
        public DBContextApplication(DbContextOptions<DBContextApplication> options)
           : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User -> Cart one-to-one
            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.Cart)
            //    .WithOne(c => c.User)
            //    .HasForeignKey<Cart>(c => c.UserId);

            //// Product -> Category many-to-one
            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.Category)
            //    .WithMany(c => c.Products)
            //    .HasForeignKey(p => p.CategoryId);

            //// Product -> Review one-to-many
            //modelBuilder.Entity<Product>()
            //    .HasMany(p => p.Reviews)
            //    .WithOne(r => r.Product)
            //    .HasForeignKey(r => r.ProductId);

            //// Order -> User many-to-one
            //modelBuilder.Entity<Order>()
            //    .HasOne(o => o.User)
            //    .WithMany(u => u.Orders)
            //    .HasForeignKey(o => o.UserId);

            //// Order -> OrderItem one-to-many
            //modelBuilder.Entity<Order>()
            //    .HasMany(o => o.OrderItems)
            //    .WithOne(oi => oi.Order)
            //    .HasForeignKey(oi => oi.OrderId);

            //// OrderItem -> Product many-to-one
            //modelBuilder.Entity<OrderItem>()
            //    .HasOne(oi => oi.Product)
            //    .WithMany(p => p.OrderItems)
            //    .HasForeignKey(oi => oi.ProductId);

            // Cart -> CartItem one-to-many
            //modelBuilder.Entity<Cart>()
            //    .HasMany(c => c.CartItems)
            //    .WithOne(ci => ci.Cart)
            //    .HasForeignKey(ci => ci.CartId);
        }










    }
}

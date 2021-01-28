using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using KH095.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace KH095.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        public static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder =>
          {
              builder.AddConsole();
          });

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // ================ user - role  | n - n 

            builder.Entity<UserRole>()
          .HasKey(e => new { e.UserId, e.RoleId });  // add primary key for table UserRoles

            builder.Entity<UserRole>()
                .HasOne(ta => ta.User)
                .WithMany(t => t.UserRoles)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<UserRole>()              // add relation  
                .HasOne(ta => ta.Role)
                .WithMany(t => t.UserRoles)
                .OnDelete(DeleteBehavior.Cascade);

            // ================ role - claim  | n - n 


            builder.Entity<RoleClaim>()
          .HasKey(e => new { e.RoleId, e.ClaimId });


            builder.Entity<RoleClaim>()
                .HasOne(ta => ta.Claim)
                .WithMany(t => t.RoleClaims)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<RoleClaim>()
                .HasOne(ta => ta.Role)
                .WithMany(t => t.RoleClaims)
                .OnDelete(DeleteBehavior.Cascade);

            // product tag 

            builder.Entity<ProductTag>()
          .HasKey(e => new { e.ProductId, e.TagId });  // add primary key for table UserRoles

            builder.Entity<ProductTag>()
                .HasOne(ta => ta.Product)
                .WithMany(t => t.ProductTags)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<ProductTag>()              // add relation  
                .HasOne(ta => ta.Tag)
                .WithMany(t => t.ProductTags)
                .OnDelete(DeleteBehavior.Cascade);
           
            // relation one - many user & order -> creator

            builder.Entity<Order>()
                .HasOne<User>(s => s.User)
                .WithMany(g => g.OrderCustomers)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // relation one - many user & order -> customer

            builder.Entity<Order>()
                .HasOne<User>(s => s.Userverify)
                .WithMany(g => g.OrderUserverify)
                .HasForeignKey(t => t.UserverifyId)
                .OnDelete(DeleteBehavior.Cascade);;
        }

        // User 

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<RoleClaim> RoleClaim { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
    }
}

using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MVCCore.Infrastructure.Configuration;

namespace MVCCore.Infrastructure.Data
{
    public class MVCDBContext : DbContext
    {
        public MVCDBContext(DbContextOptions options):base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrdersConfiguration());
            modelBuilder.ApplyConfiguration(new UsersConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
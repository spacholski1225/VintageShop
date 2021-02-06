using Microsoft.EntityFrameworkCore;
using VintageShop.Models;

namespace VintageShop.Data
{
    public class VintageShopContext : DbContext
    {
        public VintageShopContext(DbContextOptions<VintageShopContext> options) : base(options)
        {
        }

        public DbSet<Arthist> Arthists { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arthist>().ToTable("Arthist");
            modelBuilder.Entity<Album>().ToTable("Album");
        }
    }

}

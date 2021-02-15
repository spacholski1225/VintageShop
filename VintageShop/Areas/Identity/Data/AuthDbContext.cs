using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VintageShop.Areas.Identity.Data;
using VintageShop.Models;

namespace VintageShop.Data
{
    public class AuthDbContext : IdentityDbContext<VintageShopUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {
        }

        public DbSet<Arthist> Arthists { get; set; }
        public DbSet<Album> Albums { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Arthist>().ToTable("Arthist");
            builder.Entity<Album>().ToTable("Album");
        }
    }
}

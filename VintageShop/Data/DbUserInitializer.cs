using System.Linq;
using VintageShop.Areas.Identity.Data;

namespace VintageShop.Data
{
    public class DbUserInitializer
    {
        public DbUserInitializer(AuthDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.VintageShopUsers.Any())
            {
                return;
            }
            var users = new VintageShopUser[]
            {
                new VintageShopUser{Name="admin", Password="admin" }

            };
            foreach (var user in users)
            {
                context.VintageShopUsers.Add(user);
            }
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VintageShop.Models;

namespace VintageShop.Data
{
    public static class DbInitializer
    {
        public static void Initialize(VintageShopContext context)
        {
            if (context.Arthists.Any())
            {
                return;
            }
            var arthists = new Arthist[]
            {
                new Arthist{FirstName="Marilyn", LastName="Manson",Alias=null }
            };
            foreach (var arthist in arthists)
            {
                context.Arthists.Add(arthist);
            }
            context.SaveChanges();

           
            var albums = new Album[]
            {
                new Album{Name="Antichrist Superstar",}
            };
            foreach (var album in albums)
            {
                context.Albums.Add(album);
            }
            context.SaveChanges();
        }
    }
}

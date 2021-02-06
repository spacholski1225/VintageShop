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
            context.Database.EnsureCreated();
            if (context.Arthists.Any())
            {
                return;
            }
            var arthists = new Arthist[]
            {
                new Arthist{FirstName="Brian", LastName="Warner",Alias="Marilyn Manson" }
            };
            foreach (var arthist in arthists)
            {
                context.Arthists.Add(arthist);
            }
            context.SaveChanges();

           
            var albums = new Album[]
            {
                new Album{ArthistID = 1, Name="Antichrist Superstar"}
            };
            foreach (var album in albums)
            {
                context.Albums.Add(album);
            }
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VintageShop.Areas.Identity.Data;
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
                new Arthist{FirstName="Brian", LastName="Warner",Alias="Marilyn Manson" },
                new Arthist{FirstName="Kuba", LastName="Grabowski",Alias="Quebonafide" },
                new Arthist{FirstName="Maciej", LastName="Maleńczuk",Alias="Maciej Malenczuk" }
            };
            foreach (var arthist in arthists)
            {
                context.Arthists.Add(arthist);
            }
            context.SaveChanges();


            var albums = new Album[]
            {
                new Album{ArthistID = 1, Name="Antichrist Superstar", ImageUrl="https://www.revolvermag.com/sites/default/files/media/images/article/manson_0.jpg"},
                new Album{ArthistID = 2, Name="Egzotyka", ImageUrl="https://cdn.shoplo.com/9646/products/th2048/aaaf/457-800x800_product_media_46001-47000_towar_44967_115781.jpg"},
                new Album{ArthistID = 2, Name="Erotyka", ImageUrl="https://www.popkiller.pl/sites/default/files/images/quebonafide-erotyka.jpg"},
                new Album{ArthistID = 3, Name="Klauzula sumienia", ImageUrl="https://ecsmedia.pl/c/klauzula-sumienia-b-iext66104422.jpg"},
                new Album{ArthistID = 1, Name="Eat Me, Drink Me", ImageUrl="https://upload.wikimedia.org/wikipedia/en/d/d6/Marilyn_Manson_-_Eat_Me_Drink_Me.png"},
                new Album{ArthistID = 3, Name="The Ant", ImageUrl="https://magazyngitarzysta.pl/i/images/0/3/9/d2FjPTQ0OXgx_src_125039-malenczuk-cd.jpg"},
            };
            foreach (var album in albums)
            {
                context.Albums.Add(album);
            }
            context.SaveChanges();

           
          
        }
    }
}

﻿using System;
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
                new Album{ArthistID = 1, Name="Antichrist Superstar", ImageUrl="~/images/manson_as.png"},
                new Album{ArthistID = 2, Name="Egzotyka", ImageUrl="~/images/q_egz.jpg" },
                new Album{ArthistID = 2, Name="Erotyka", ImageUrl="~/images/q_erotyka.jpg"},
                new Album{ArthistID = 3, Name="Klauzula sumienia", ImageUrl="~/images/malenczuk_klauzula.jpg"},
                new Album{ArthistID = 1, Name="Eat Me, Drink Me", ImageUrl="~/images/manson_eat.png"},
                new Album{ArthistID = 3, Name="The Ant", ImageUrl="~/images/malenczuk_ant.png"},
            };
            foreach (var album in albums)
            {
                context.Albums.Add(album);
            }
            context.SaveChanges();

           
          
        }
    }
}

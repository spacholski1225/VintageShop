using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace VintageShop.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the VintageShopUser class
    public class VintageShopUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "navchar(100)")]
        public string  FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "navchar(100)")]
        public string  LastName { get; set; }
    }
}

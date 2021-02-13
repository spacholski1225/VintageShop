using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VintageShop.Models
{
    public class UserAccount
    {
        [Key]
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}

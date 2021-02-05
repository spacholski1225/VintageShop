using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VintageShop.Models
{
    public class Arthist
    {
        public int ID { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string Alias { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}

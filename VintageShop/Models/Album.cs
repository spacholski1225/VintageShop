using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VintageShop.Models
{
    public class Album
    {
        public int AlbumID{ get; set; }
        public int ArthistID{ get; set; }

        public string Name{ get; set; }

        public Arthist Arthist { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGallery.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}

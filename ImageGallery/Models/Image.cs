using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGallery.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public string Caption { get; set; }
        public DateTime Created { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
        public string Filter { get; set; } = "none";
        public string UserID { get; set; }
        public string UserName { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int AlbumID { get; set; }
        public Album Album { get; set; }
    }
}

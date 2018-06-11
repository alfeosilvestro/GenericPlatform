using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.GenericPlatform.WebApp.Models
{
    public class BM_GalleryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ThumbnailImage { get; set; }
        public string DetailImage { get; set; }
        public string DownloadableImage { get; set; }
    }
}

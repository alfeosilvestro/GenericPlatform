using Com.PlatformServices.Common.FoundationClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.PlatformServices.BudgetMetal.Requests
{
    public class GalleriesRequestModel : BaseRequestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ThumbnailImage { get; set; }
        public string DetailImage { get; set; }
        public string DownloadableImage { get; set; }

    }
}

using Com.PlatformServices.Common.FoundationClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.PlatformServices.Common.DAL.Entities.BudgetMetal
{
    [Table("BM_Gallery")]
    public class BM_Gallery : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ThumbnailImage { get; set; }

        public string DetailImage { get; set; }

        public string DownloadableImage { get; set; }
    }
}

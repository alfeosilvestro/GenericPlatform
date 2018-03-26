using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.Common.DAL.Entities.SystemSettings
{
    [Table("Sys_Setting_Code")]
    public class Sys_Setting_Code : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("ParentCodeId")]
        public Sys_Setting_Code Parent { get; set; }

        public ICollection<Sys_Setting_Code> Children { get; set; }
    }
}

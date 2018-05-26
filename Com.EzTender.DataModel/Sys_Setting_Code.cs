using Com.EzTender.DataModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Com.EzTender.DataModel
{
    [Table("Sys_Setting_Code")]
    public class Sys_Setting_Code : GenericEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("ParentCodeId")]
        public Sys_Setting_Code Parent { get; set; }

        public ICollection<Sys_Setting_Code> Children { get; set; }
    }
}

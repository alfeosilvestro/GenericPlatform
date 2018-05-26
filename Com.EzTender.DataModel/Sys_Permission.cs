using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Com.EzTender.DataModel.Base;

namespace Com.EzTender.DataModel
{
    [Table("Sys_Permission")]
    public class Sys_Permission : GenericEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("Sys_Role_Id")]
        public Sys_Role Parent { get; set; }
    }
}
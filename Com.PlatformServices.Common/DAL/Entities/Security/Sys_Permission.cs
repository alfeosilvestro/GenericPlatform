using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.Common.DAL.Entities.Security
{
    [Table("Sys_Permission")]
    public class Sys_Permission : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("Sys_Role_Id")]
        public Sys_Role Parent { get; set; }
    }
}
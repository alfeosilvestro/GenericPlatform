using Com.PlatformServices.Common.FoundationClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.PlatformServices.Common.DAL.Entities.SystemUser
{
    [Table("Sys_User_Role")]
    public class Sys_User_Role : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [ForeignKey("UserID")]
        public Sys_User user { get; set; } 

    }
}

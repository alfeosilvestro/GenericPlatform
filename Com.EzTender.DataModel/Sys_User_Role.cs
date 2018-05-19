using Com.EzTender.DataModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.EzTender.DataModel
{
    [Table("Sys_User_Role")]
    public class Sys_User_Role : GenericEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [ForeignKey("UserID")]
        public Sys_User user { get; set; } 

    }
}

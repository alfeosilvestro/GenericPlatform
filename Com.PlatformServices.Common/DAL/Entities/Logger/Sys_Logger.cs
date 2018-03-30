using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.Common.DAL.Entities.Logger
{
    
    [Table("Sys_Logger")]
    public class Sys_Logger : BaseEntity
    {
        public string Log_Title { get; set; }
        public string Application_ID { get; set; }
        public string Log_Type { get; set; }
        public string Log_Message { get; set; }
    }
}

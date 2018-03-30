using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.Common.DAL.Entities.Logger
{
    
    [Table("Sys_Logger")]
    public class Sys_Logger : BaseEntity
    {
        public string LogTitle { get; set; }
        public string ApplicationId { get; set; }
        public string LogType { get; set; }
        public string LogMessage { get; set; }
    }
}

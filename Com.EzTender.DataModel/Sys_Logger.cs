using Com.EzTender.DataModel.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Com.EzTender.DataModel
{
    
    [Table("Sys_Logger")]
    public class Sys_Logger : GenericEntity
    {
        public string LogTitle { get; set; }
        public string ApplicationId { get; set; }
        public string LogType { get; set; }
        public string LogMessage { get; set; }
    }
}

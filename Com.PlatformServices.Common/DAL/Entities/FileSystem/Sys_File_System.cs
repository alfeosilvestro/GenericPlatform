﻿using Com.PlatformServices.Common.FoundationClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.PlatformServices.Common.DAL.Entities.FileSystem
{
    [Table("Sys_File_System")]
    public class Sys_File_System : BaseEntity
    {
        
        public string FileName { get; set; }

        public string FileDescription { get; set; }

        public string OriginalFileName { get; set; }

        /// <summary>
        /// Base 64 String
        /// </summary>
        public string FileContent { get; set; }

        /// <summary>
        /// ID of application
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Company Id
        /// </summary>
        public string Reference1 { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        public string Reference2 { get; set; }

        /// <summary>
        /// Document Id
        /// </summary>
        public string Reference3 { get; set; }

    }
}

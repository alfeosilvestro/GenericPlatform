using Com.EzTender.DataModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Com.EzTender.DataModel
{
    [Table("Sys_File_System")]
    public class Sys_File_System : GenericEntity
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string FileName { get; set; }

        public string FileDescription { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Base 64 String
        /// </summary>
        [Required]
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

        [StringLength(5, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        public string FileExtension { get; set; }
    }
}

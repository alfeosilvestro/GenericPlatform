using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Com.PlatformServices.Common.FoundationClasses;

namespace Com.PlatformServices.Common.DAL.Entities.Security
{
    [Table("Sys_Role")]
    public class Sys_Role : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public ICollection<Sys_Permission> Children { get; set; }
    }
}
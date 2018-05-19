using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Com.EzTender.DataModel.Base;

namespace Com.EzTender.DataModel
{
    [Table("Sys_Role")]
    public class Sys_Role : GenericEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public ICollection<Sys_Permission> Children { get; set; }
    }
}
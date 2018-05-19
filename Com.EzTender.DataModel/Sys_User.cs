using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Com.EzTender.DataModel.Base;

namespace Com.EzTender.DataModel
{
    [Table("Sys_User")]
    public class Sys_User : GenericEntity
    {
        public int ID { get; set; }
        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Password doesn't meet the requirements")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [StringLength(100, ErrorMessage = "100 Characters max")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string Active { get; set; }

        public ICollection<Sys_User_Role> UserRoles { get; set; }
    }
}

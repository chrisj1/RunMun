using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunMun.Models.ManageViewModels
{
    public enum Roles {
        Delegation,
        Secretariat,
        Chair
    }
    
    public class UsersViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Firstname")]
        public string Firstname { get; set; }
        [Required]
        [Display(Name = "Lastname")]
        public string Lastname { get; set; }
        [Required]
        [Display(Name = "Role")]
        [EnumDataType(typeof(Roles))]
        public Roles Role { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        [StringLength(maximumLength:10, MinimumLength = 10)]
        public string PhoneNumber { get; set; }

        [Display(Name = "School")]
        public string School { get; set; }
        [Required]
        public string Id { get; set; }
    }
}

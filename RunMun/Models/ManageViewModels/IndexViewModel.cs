using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunMun.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        [Required]
        [Display(Name = "Firstname")]
        public string Firstname { get; set; }

        [Required]
        [Display(Name = "Lastname")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "School")]
        public string School { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}

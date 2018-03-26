using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunMun.Models.ManageViewModels
{
    public class ManageCommitteeViewModel
    {
        [HiddenInput]
        [ReadOnly(true)]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Committee Name")]
        public string Name { get; set; }

        [Display(Name ="Positions Count")]
        [ReadOnly(true)]
        public int Positions { get; set; }

        [Display(Name = "Base Committee")]
        [ReadOnly(true)]
        public string BaseCommittee { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunMun.Models
{
    public class Position
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string name;

        [Required]
        public Committee Committee;

        public Position()
        {

        }
    }
}

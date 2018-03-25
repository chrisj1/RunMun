﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RunMun.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class  ApplicationUser: IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string School { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RunMun.Data;
using RunMun.Models;
using RunMun.Services;

public class IdentityDataInitializer
{
	public static void SeedData(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {

    }

    public static void SeedUsers(UserManager<ApplicationUser> userManager)
    {
        if (userManager.FindByNameAsync("Root").Result == null)
        {
            ApplicationUser user = new ApplicationUser();
            user.UserName = "Root";
            user.Firstname = "Chris";
            user.Lastname = "Jerrett";
            user.School = null;
            user.Email = "cjerrett18@stjohnsprep.org";

            IdentityResult result = userManager.CreateAsync(user, "Root1234!").Result;

            if (result.Succeeded)
            {
                userManager.AddToRoleAsync(user, "Administrator").Wait();
            }
        }
    } 

    public static void SeedRoles(RoleManager<IdentityRole> roleManager)
    {
        if (!roleManager.RoleExistsAsync("Administrator").Result)
        {
            IdentityRole role = new IdentityRole();
            role.Name = "Administrator";
            IdentityResult roleResult = roleManager.
            CreateAsync(role).Result;
        }

        if (!roleManager.RoleExistsAsync("Secretariat").Result)
        {
            IdentityRole role = new IdentityRole();
            role.Name = "Secretariat";
            IdentityResult roleResult = roleManager.
            CreateAsync(role).Result;
        }

        if (!roleManager.RoleExistsAsync("Delegation").Result)
        {
            IdentityRole role = new IdentityRole();
            role.Name = "Delegation";
            IdentityResult roleResult = roleManager.
            CreateAsync(role).Result;
        }
    }
}

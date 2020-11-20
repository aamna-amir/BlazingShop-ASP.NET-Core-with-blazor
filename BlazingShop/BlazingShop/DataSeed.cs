using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop
{
    public static class DataSeed
    {
        public static void Seed(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)

        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            var users = userManager.GetUsersInRoleAsync("Admin").Result;

            if (userManager.FindByNameAsync("Aptech").Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = "Aptech",
                    Email = "aptech@app.acegrw.app",
                    EmailConfirmed = true
                };
                var result = userManager.CreateAsync(user, "Aptech@2020").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }

            if (userManager.FindByNameAsync("Altamash").Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = "Altamash",
                    Email = "Altamash@app.acegrw.app",
                    EmailConfirmed = true
                };
                var result = userManager.CreateAsync(user, "Altamash@2020").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Counsellor").Wait();
                }
            }

            if (userManager.FindByNameAsync("Zeeshan").Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = "Zeeshan",
                    Email = "Zeeshan@app.acegrw.app",
                    EmailConfirmed = true
                };
                var result = userManager.CreateAsync(user, "Zeeshan@2020").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Counsellor").Wait();
                }
            }

            if (userManager.FindByNameAsync("Nadia").Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = "Nadia",
                    Email = "Nadia@app.acegrw.app",
                    EmailConfirmed = true
                };
                var result = userManager.CreateAsync(user, "Nadia@2020").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Counsellor").Wait();
                }
            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Admin"
                };
                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Counsellor").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Counsellor"
                };
                var result = roleManager.CreateAsync(role).Result;
            }
        }
    }
}

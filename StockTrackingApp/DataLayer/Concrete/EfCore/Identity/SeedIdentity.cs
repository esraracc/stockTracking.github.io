using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete.EfCore.Identity
{
    public class SeedIdentity
    {
        public static async Task SeedAsync(IConfiguration Configuration, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            var username = Configuration["Data:AdminUser:username"];
            var password = Configuration["Data:AdminUser:password"];
            var email = Configuration["Data:AdminUser:email"];
            var role = Configuration["Data:AdminUser:role"];

            if (await userManager.FindByNameAsync(username) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role));

                var user = new User()
                {
                    UserName = username,
                    Email = email,
                    FirstName = "Cesur",
                    LastName = "PİŞKİN",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}

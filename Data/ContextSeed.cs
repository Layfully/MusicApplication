
using Microsoft.AspNetCore.Identity;
using MusicApplication.Data.Entities;
using MusicApplication.Enums;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Podstawowa.ToString()));
        }

        public static async Task SeedSuperAdminAsync(UserManager<User> userManager)
        {
            //Seed Default User
            var superUser = new User
            {
                UserName = "root",
                Email = "superadmin@gmail.com",
                FirstName = "Adrian",
                LastName = "Gaborek",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != superUser.Id))
            {
                var user = await userManager.FindByEmailAsync(superUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(superUser, "Root123#");
                    await userManager.AddToRoleAsync(superUser, Roles.Podstawowa.ToString());
                    await userManager.AddToRoleAsync(superUser, Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(superUser, Roles.SuperAdmin.ToString());
                }
            }
        }
    }
}

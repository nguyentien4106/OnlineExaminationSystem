using Microsoft.AspNetCore.Identity;
using OnlineExaminationSystem.Data;
using OnlineExaminationSystem.Common.Enums;

namespace OnlineExaminationSystem.Helper
{
    public static class Seed
    {
        public static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            var admin = await roleManager.FindByNameAsync(Roles.Admin.ToString());
            if (admin == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            }
            var teacher = await roleManager.FindByNameAsync(Roles.Teacher.ToString());
            if (teacher == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Roles.Teacher.ToString()));
            }
            var student = await roleManager.FindByNameAsync(Roles.Student.ToString());
            if (student == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Roles.Student.ToString()));
            }
        }

        public static async Task SeedUsers(UserManager<AppUser> userManager)
        {
            var user = await userManager.FindByNameAsync("super@admin.com");
            if (user == null)
            {
                user = new AppUser
                {
                    FirstName = "Super",
                    LastName = "Admin",
                    DOB = DateTime.Now,
                    Grade = -1,
                    Email = "super@admin"
                };

                var result = await userManager.CreateAsync(user, "Ti100600@");
                await userManager.AddToRoleAsync(user, Roles.Student.ToString());
                await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
                await userManager.AddToRoleAsync(user, Roles.Teacher.ToString());
            }
        }
    }
}
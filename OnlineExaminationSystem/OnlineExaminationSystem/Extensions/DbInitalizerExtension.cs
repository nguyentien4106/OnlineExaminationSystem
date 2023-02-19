using Microsoft.AspNetCore.Identity;
using OnlineExaminationSystem.Data;
using OnlineExaminationSystem.Helper;

namespace OnlineExaminationSystem.Extensions
{
    public static class DbInitalizerExtension
    {
        public static async Task<IApplicationBuilder> SeedRoles(this IApplicationBuilder app)
        {
            ArgumentNullException.ThrowIfNull(app, nameof(app));

            using var scope = app.ApplicationServices.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var userManager = services.GetRequiredService<UserManager<AppUser>>();
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                await Seed.SeedRoles(roleManager);
                await Seed.SeedUsers(userManager);
            }
            catch (Exception ex)
            {
            }

            return app;
        }
    }
}
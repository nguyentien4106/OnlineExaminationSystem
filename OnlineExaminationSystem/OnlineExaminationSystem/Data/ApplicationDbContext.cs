using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Data.Model;
using OnlineExaminationSystem.Common.Model;

namespace OnlineExaminationSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<OnlineExaminationSystem.Common.Model.UserModel> UserModel { get; set; }
    }
}
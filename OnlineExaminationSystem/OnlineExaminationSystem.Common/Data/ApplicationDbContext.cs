using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Data.Model;

namespace OnlineExaminationSystem.Common.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Question> Question { get; set; }

        public DbSet<Answer> Answer { get; set; }
        public DbSet<CDIO> CDIO { get; set; }
    }
}
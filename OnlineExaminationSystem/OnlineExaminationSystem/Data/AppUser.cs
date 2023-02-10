using Microsoft.AspNetCore.Identity;

namespace OnlineExaminationSystem.Data
{
    public class AppUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }

        [PersonalData]
        public int Grade { get; set; }

    }
}

using OnlineExaminationSystem.Common.Model;
using OnlineExaminationSystem.Data;

namespace OnlineExaminationSystem.Areas.Admin.Service.Implement
{
    public class ManageUserService : IManageUserService
    {
        private ApplicationDbContext _context;

        public ManageUserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<UserModel> GetAllUsers()
        {
            var users = _context.Users.Select(u => new UserModel
            {
                Id = u.Id,
                Email = u.Email,
                FirstName = u.FirstName,
                LastName = u.LastName,
                PhoneNumber = u.PhoneNumber,
            }).ToList();

            foreach(var user in users)
            {
                user.Roles = (GetUserRole(user));
            }

            return users;
        }

        private string GetUserRole(UserModel user)
        {
            var roleIds = _context.UserRoles.Where(u => u.UserId == user.Id).Select(u => u.RoleId).ToList();

            return string.Join(", ", _context.Roles.Where(r => roleIds.Contains(r.Id)).Select(r => r.Name).ToList());
        }
    }
}

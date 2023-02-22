//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using OnlineExaminationSystem.Common.Model;
//using OnlineExaminationSystem.Common.Model.DTO;
//using OnlineExaminationSystem.Data;

//namespace OnlineExaminationSystem.Areas.Admin.Service.Implement
//{
//    public class ManageUserService : IManageUserService
//    {
//        private readonly ApplicationDbContext _context;
//        private readonly UserManager<AppUser> _userManager;
//        private IUserStore<AppUser> _userStore;

//        public ManageUserService(
//            ApplicationDbContext context,
//            UserManager<AppUser> userManager,
//            IUserStore<AppUser> userStore
//            )
//        {
//            _context = context;
//            _userManager = userManager;
//            _userStore = userStore;
//        }

//        public async Task CreateUser(UserModel user)
//        {
//            var newUser = CreateAppUser(user);
//            var roles = GetRoles(user);
//            await _userStore.SetUserNameAsync(newUser, user.Email, CancellationToken.None);
//            //await _userEmailStore.SetEmailAsync(newUser, user.Email, CancellationToken.None);
//            await _userManager.CreateAsync(newUser, user.Password);
//            await _userManager.AddToRolesAsync(newUser, roles);
//        }

//        public List<UserModel> GetAllUsers()
//        {
//            var users = _context.Users.Select(u => new UserModel
//            {
//                Id = u.Id,
//                Email = u.Email,
//                FirstName = u.FirstName,
//                LastName = u.LastName,
//                PhoneNumber = u.PhoneNumber,
//            }).ToList();

//            foreach (var user in users)
//            {
//                user.Roles = GetUserRole(user);
//            }

//            return users;
//        }

//        public async Task<UserDTO> GetUser(string id)
//        {
//            var user = await _context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();

//            if (user == null)
//            {
//                return new UserDTO();
//            }

//            return new UserDTO
//            {
//                FirstName = user.FirstName,
//                LastName = user.LastName,
//                PhoneNumber = user.PhoneNumber,
//                Email = user.Email,
//                DOB = user.DOB
//            };
//        }

//        private string GetUserRole(UserModel user)
//        {
//            var roleIds = _context.UserRoles.Where(u => u.UserId == user.Id).Select(u => u.RoleId).ToList();

//            return string.Join(", ", _context.Roles.Where(r => roleIds.Contains(r.Id)).Select(r => r.Name).ToList());
//        }

//        private AppUser CreateAppUser(UserModel user)
//        {
//            return new AppUser
//            {
//                FirstName = user.FirstName,
//                LastName = user.LastName,
//                PhoneNumber = user.PhoneNumber,
//                Email = user.Email,
//            };
//        }

//        private static IEnumerable<string> GetRoles(UserModel user) => user.Roles.Split(",").ToList();

//        public async Task<AppUser?> DeleteUser(string id)
//        {
//            var user = await _context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();

//            if(user != null)
//            {
//                await _userManager.DeleteAsync(user);

//                return user;
//            }

//            return null;
//        }

//        public async Task UpdateUser(string id, UserDTO user)
//        {
//            var appUser = _context.Users.FirstOrDefault(u => u.Id == id);

//            if(appUser != null)
//            {
//                Update(appUser, user);
//                await _userManager.UpdateAsync(appUser);
//            }

//        }

//        private void Update(AppUser appUser, UserDTO user)
//        {
//            appUser.DOB = user.DOB;
//            appUser.FirstName = user.FirstName;
//            appUser.LastName = user.LastName;
//            appUser.PhoneNumber = user.PhoneNumber;
//            appUser.Email = user.Email;
//            appUser.Grade = user.Grade;

//        }
//    }
//}
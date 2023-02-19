using OnlineExaminationSystem.Common.Model;
using OnlineExaminationSystem.Common.Model.DTO;
using OnlineExaminationSystem.Data;

namespace OnlineExaminationSystem.Areas.Admin.Service
{
    public interface IManageUserService
    {
        List<UserModel> GetAllUsers();

        Task<UserDTO> GetUser(string id);

        Task CreateUser(UserModel user);
        Task<AppUser> DeleteUser(string id);

        Task UpdateUser(string id, UserDTO user);
    }
}
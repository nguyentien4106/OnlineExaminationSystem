using OnlineExaminationSystem.Common.Model;

namespace OnlineExaminationSystem.Areas.Admin.Service
{
    public interface IManageUserService
    {
        List<UserModel> GetAllUsers();

    }
}

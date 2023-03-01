using OnlineExaminationSystem.Admin.Service;
using OnlineExaminationSystem.Admin.Service.Implement;
using OnlineExaminationSystem.Areas.Admin.Service;
using OnlineExaminationSystem.Areas.Admin.Service.Implement;

namespace OnlineExaminationSystem.Extensions
{
    public static class DenpendencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection builder)
        {
            builder.AddScoped<IManageUserService, ManageUserService>();
            builder.AddScoped<IManageQuestionService, ManageQuestionService>();
            builder.AddScoped<IManageCDIOService, ManageCDIOService>();

            return builder;
        }
    }
}
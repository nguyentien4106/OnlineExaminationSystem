using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OnlineExaminationSystem.Areas.Admin.Service;
using OnlineExaminationSystem.Areas.Admin.Service.Implement;
using OnlineExaminationSystem.Data;

namespace OnlineExaminationSystem.Extensions
{
    public static class DenpendencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection builder)
        {
            builder.AddScoped<IManageUserService, ManageUserService>();
            builder.AddScoped<IQuestionService, QuestionService>();

            return builder;
        }
    }
}

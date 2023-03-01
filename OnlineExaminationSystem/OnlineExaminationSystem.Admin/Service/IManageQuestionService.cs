using OnlineExaminationSystem.Common.Data.Model;

namespace OnlineExaminationSystem.Areas.Admin.Service
{
    public interface IManageQuestionService
    {
        Task<List<Question>> GetAllQuestions();

        Task CreateQuestion(Question questionDTO);
    }
}
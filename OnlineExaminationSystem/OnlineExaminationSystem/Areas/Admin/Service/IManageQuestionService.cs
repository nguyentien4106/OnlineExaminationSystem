using OnlineExaminationSystem.Common.Model.DTO;

namespace OnlineExaminationSystem.Areas.Admin.Service
{
    public interface IManageQuestionService
    {
        Task<List<QuestionDTO>> GetAllQuestions();

        Task CreateQuestion(QuestionDTO questionDTO);
    }
}
using OnlineExaminationSystem.Data;
using OnlineExaminationSystem.Enums;

namespace OnlineExaminationSystem.Areas.Admin.Service.Implement
{
    public class QuestionService : IQuestionService
    {
        private ApplicationDbContext _context;

        public QuestionService(ApplicationDbContext context)
        {
            _context= context;
        }

        public List<string> GetSubjects()
        {
            var result = new List<string>();

            foreach(var item in Enum.GetValues(typeof(Subject)))
            {
                result.Add(item.ToString());
            }

            return result;
        }
    }
}

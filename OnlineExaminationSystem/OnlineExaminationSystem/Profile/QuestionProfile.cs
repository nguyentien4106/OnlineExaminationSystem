using OnlineExaminationSystem.Common.Model.DTO;
using OnlineExaminationSystem.Data.Model;

namespace OnlineExaminationSystem.Profile
{
    public class QuestionProfile : AutoMapper.Profile
    {
        public QuestionProfile()
        {
            CreateMap<Question, QuestionDTO>();
            CreateMap<QuestionDTO, Question>();
        }
    }
}
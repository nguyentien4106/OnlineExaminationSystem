//using OnlineExaminationSystem.Data;
//using OnlineExaminationSystem.Common.Enums;
//using OnlineExaminationSystem.Common.Model.DTO;
//using Microsoft.EntityFrameworkCore;
//using AutoMapper;
//using OnlineExaminationSystem.Data.Model;

//namespace OnlineExaminationSystem.Areas.Admin.Service.Implement
//{
//    public class ManageQuestionService : IManageQuestionService
//    {
//        private ApplicationDbContext _context;
//        private readonly IMapper _mapper;

//        public ManageQuestionService(ApplicationDbContext context, IMapper mapper)
//        {
//            _context = context;
//            _mapper = mapper;
//        }

//        public async Task<List<QuestionDTO>> GetAllQuestions()
//        {
//            var questions = await _context.Question.Include(item => item.Answers).Include(item => item.CDIOs).ToListAsync();

//            var questionsDTO = _mapper.Map<List<QuestionDTO>>(questions);

//            return questionsDTO;

//        }

//        public Task CreateQuestion(QuestionDTO questionDTO)
//        {
//            var question = _mapper.Map<Question>(questionDTO);

//            return question;
//        }
//    }
//}
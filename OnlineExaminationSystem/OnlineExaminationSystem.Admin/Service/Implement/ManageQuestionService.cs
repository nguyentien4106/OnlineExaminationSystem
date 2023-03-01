using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Common.Data;
using OnlineExaminationSystem.Common.Data.Model;

namespace OnlineExaminationSystem.Areas.Admin.Service.Implement
{
    public class ManageQuestionService : IManageQuestionService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ManageQuestionService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Question>> GetAllQuestions()
        {
            var questions = await _context.Question.Include(item => item.Answers).Include(item => item.CDIOs).ToListAsync();

            return questions;
        }

        public async Task CreateQuestion(Question questionDTO)
        {
            var question = _mapper.Map<Question>(questionDTO);

            await _context.Question.AddAsync(question);

            await _context.SaveChangesAsync();
        }
    }
}
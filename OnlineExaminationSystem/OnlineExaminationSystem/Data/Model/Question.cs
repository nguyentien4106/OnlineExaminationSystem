using OnlineExaminationSystem.Enums;

namespace OnlineExaminationSystem.Data.Model
{
    public class Question
    {
        public Guid Id { get; set; }

        public Level Level { get; set; }
        
        public string? Code { get; set; }

        public string? Content { get; set; }

        public List<Answer>? Answers { get; set; }

        public int AnswerKey { get; set; }

        public Subject Subject { get; set; }

    }
}

namespace OnlineExaminationSystem.Common.Model.DTO
{
    public class QuestionDTO
    {
        public string? Level { get; set; }

        public string? Code { get; set; }

        public string? Content { get; set; }

        public List<string>? Answers { get; set; }

        public int? AnswerKey { get; set; }

        public string? Subject { get; set; }

        public List<string>? CDIOs { get; set; }
    }
}
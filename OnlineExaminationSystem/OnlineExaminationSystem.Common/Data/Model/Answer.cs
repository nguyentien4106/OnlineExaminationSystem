namespace OnlineExaminationSystem.Common.Data.Model
{
    public class Answer
    {
        public Guid Id { get; set; }

        public Guid QuestionId { get; set; }

        public string? Content { get; set; }
    }
}
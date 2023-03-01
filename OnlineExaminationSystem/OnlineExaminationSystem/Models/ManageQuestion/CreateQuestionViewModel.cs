using Microsoft.Build.Framework;
using OnlineExaminationSystem.Common.Data.Model;
using OnlineExaminationSystem.Common.Enums;

namespace OnlineExaminationSystem.Models.ManageQuestion
{
    public class CreateQuestionViewModel
    {
        [Required]
        public Level? Level { get; set; }

        [Required]
        public string? Code { get; set; }

        [Required]
        public string? Content { get; set; }

        [Required]
        public List<Answer>? Answers { get; set; }

        [Required]
        public int? AnswerKey { get; set; }

        [Required]
        public Subject? Subject { get; set; }

        public List<CDIO>? CDIOs { get; set; }

        public List<string> SubjectItems => GetSubjects();
        public List<int> LevelItems => GetLevels();

        private List<string> GetSubjects()
        {
            var subjects = new List<string>();

            foreach (var subject in Enum.GetValues(typeof(Subject)))
            {
                subjects.Add(Enum.GetName(typeof(Subject), subject));
            }

            return subjects;
        }

        private List<int> GetLevels()
        {
            var levels = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                levels.Add(i);
            }

            return levels;
        }
    }
}
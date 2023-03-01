using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineExaminationSystem.Common.Data.Model
{
    public class CDIO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string? Subject { get; set; }

        public string? Name { get; set; }
    }
}
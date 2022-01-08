using System.ComponentModel.DataAnnotations;

namespace FeedbackSystem.Models
{
    public class Question
    {
        [Key]
        public int Qid { get; set; }

        public string Questions { get; set; }

        public Type QType { get; set; }
    }
}

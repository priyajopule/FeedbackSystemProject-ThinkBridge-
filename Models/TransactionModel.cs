using System.ComponentModel.DataAnnotations;

namespace FeedbackSystem.Models
{
    public class TransactionModel
    {
        [Key]
        public int Tid { get; set; }
        public int ProductID { get; set; }

        public int SurveyID { get; set; }

        public int QuestionID { get; set; }

        public string Answer { get; set; }

        public Type Type { get; set; }
    }
}

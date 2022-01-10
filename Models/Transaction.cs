using System.ComponentModel.DataAnnotations;

namespace FeedbackSystem.Models
{
   /* public class Transaction
    {
        [Key]
        public int Tid { get; set; }
        public Product Product { get; set; }

        public Survey Survey { get; set; }

        public Question Question { get; set; }

        public string Answer { get; set; }

        public Type Type { get; set; }
    }*/

    /// <summary>
    /// transaction table model
    /// </summary>
    public class Transaction
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

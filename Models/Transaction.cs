using System.ComponentModel.DataAnnotations;

namespace FeedbackSystem.Models
{
    public class Transaction
    {
        [Key]
        public int Tid { get; set; }
        public Product Product { get; set; }

        public Survey Survey { get; set; }

        public Question Question { get; set; }

        public string Answer { get; set; }

        public Type Type { get; set; }


    }
}

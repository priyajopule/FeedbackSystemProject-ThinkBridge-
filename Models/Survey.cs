using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FeedbackSystem.Models
{
    public class Survey
    {
        [Key]
        public int Sid { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public List<Transaction> surveyTransaction { get; set; }
    }
}

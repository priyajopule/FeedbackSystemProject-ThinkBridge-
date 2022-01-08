using System.ComponentModel.DataAnnotations;

namespace FeedbackSystem.Models
{

    /// <summary>
    /// master table for product
    /// </summary>
    public class Product
    {

        [Key]
        public int Pid { get; set; }

        public string PName { get; set; }

        public string Url { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace FeedbackSystem.Models
{
    public class User
    {
        [Key]
        public int Uid { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public int Role { get; set; }

    }
}

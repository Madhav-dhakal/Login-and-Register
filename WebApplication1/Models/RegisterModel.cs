using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RegisterModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string FullName{ get; set; }

        [Required]
        [StringLength(25)]
        [EmailAddress]
        [RegularExpression("^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,6}$|^$|^ $", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\+?\d+$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,15}$",ErrorMessage = "Password must have at least one lowercase,Uppercase,OnespecialChar and one digit.")]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name is required.")]
        [StringLength(100, ErrorMessage = "Full Name cannot be longer than 100 characters.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mobile Number is required.")]
        [Phone(ErrorMessage = "Invalid mobile number.")]
        [StringLength(15, ErrorMessage = "Mobile Number cannot be longer than 15 characters.")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters.")]
        public string Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Role { get; set; } = "User"; // Default role set to "User"
    }
}

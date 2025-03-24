using System.ComponentModel.DataAnnotations;

namespace blaz3.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Email обязателен для заполнения.")]
        [EmailAddress(ErrorMessage = "Некорректный адрес электронной почты.")]
        public string Email { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Пароль обязателен для заполнения.")]
        [StringLength(100, ErrorMessage = "Пароль должен содержать не менее {2} символов.", MinimumLength = 6)]
        public string Password { get; set; }
        public string Role { get; set; }
    }
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

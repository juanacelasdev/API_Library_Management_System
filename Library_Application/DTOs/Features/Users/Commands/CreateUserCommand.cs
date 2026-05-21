using System.ComponentModel.DataAnnotations;

namespace Library.Application.DTOs.Features.Users.Commands
{
    public class CreateUserCommand
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public int Role { get; set; }

        public bool IsActive { get; set; }
    }
}
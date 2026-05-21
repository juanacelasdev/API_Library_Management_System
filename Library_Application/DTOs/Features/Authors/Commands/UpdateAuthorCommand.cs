using System.ComponentModel.DataAnnotations;

namespace Library.Application.Features.Authors.Commands
{
    public class UpdateAuthorCommand
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
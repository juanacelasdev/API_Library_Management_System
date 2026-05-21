using System.ComponentModel.DataAnnotations;

namespace Library.Application.DTOs.Features.Categories.Commands
{
    public class CreateCategoryCommand
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
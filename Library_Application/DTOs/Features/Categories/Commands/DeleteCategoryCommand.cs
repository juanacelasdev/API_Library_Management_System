namespace Library.Application.DTOs.Features.Categories.Commands
{
    public class DeleteCategoryCommand
    {
        public int Id { get; set; }

        public DeleteCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
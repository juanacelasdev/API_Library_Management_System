namespace Library.Application.DTOs.Features.Books.Commands
{
    public class DeleteBookCommand
    {
        public int Id { get; set; }

        public DeleteBookCommand(int id)
        {
            Id = id;
        }
    }
}
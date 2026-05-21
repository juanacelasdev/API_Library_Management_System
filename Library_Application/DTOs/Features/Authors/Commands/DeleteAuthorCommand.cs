namespace Library.Application.Features.Authors.Commands
{
    public class DeleteAuthorCommand
    {
        public int Id { get; set; }

        public DeleteAuthorCommand(int id)
        {
            Id = id;
        }
    }
}
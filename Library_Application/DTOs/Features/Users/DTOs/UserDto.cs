namespace Library.Application.DTOs.Features.Users.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Role { get; set; }

        public bool IsActive { get; set; }
    }
}
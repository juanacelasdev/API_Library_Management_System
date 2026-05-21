namespace Library.Application.DTOs.Features.Auth.DTOs
{
    public class AuthResponseDto
    {
        public string Token { get; set; }

        public DateTime Expiration { get; set; }
    }
}
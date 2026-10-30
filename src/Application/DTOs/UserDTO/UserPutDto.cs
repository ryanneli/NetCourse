using System.ComponentModel.DataAnnotations;
using API.Domain.Entities;
namespace API.Application.DTO
{
    public class UserPutDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Profile { get; set; } = string.Empty;
        [Required]
        public string? Password { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using API.Domain.Entities;
namespace API.Application.DTO
{
    public class UserGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Profile { get; set; } = string.Empty;
        public bool Excluido { get; set; }
    }

}
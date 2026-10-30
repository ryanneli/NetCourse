using System.ComponentModel.DataAnnotations;
using API.Domain.Entities;
namespace API.Application.DTO
{
    public class RegistrationGetDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int GroupId { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool Excluido { get; set; }
        public bool IsActive { get; set; }

        public UserGetDto User { get; set; } = new UserGetDto();
        public GroupGetDto Group { get; set; } = new GroupGetDto();
    }
    
}
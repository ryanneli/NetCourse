using System.ComponentModel.DataAnnotations;
using API.Domain.Entities;
namespace API.Application.DTO;

public class GroupGetDto
{
    public int Id { get; set; }
    public int GroupId { get; set; }
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    public int CourseId { get; set; }

    public bool Excluido { get; set; }
}
using System.ComponentModel.DataAnnotations;
using API.Domain.Entities;
namespace API.Application.DTO;

public class GroupPutDto
{
    [Required]
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    [Required]
    public int Id { get; set; }

    [Required]
    public int GroupId { get; set; }
    
    [Required]
    public int CourseId { get; set; }
    
}
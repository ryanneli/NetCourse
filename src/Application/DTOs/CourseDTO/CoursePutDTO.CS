using System.ComponentModel.DataAnnotations;

namespace API.Application.DTO
{
    public class CoursePutDto
    {

        [Required(ErrorMessage ="é obrigatório o Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres no campo")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [MaxLength(50, ErrorMessage = "Máximo de 100 caracteres")]
        public string Description { get; set; } = string.Empty;

    }
}
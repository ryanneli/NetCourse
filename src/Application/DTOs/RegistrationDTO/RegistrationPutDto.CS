using System.ComponentModel.DataAnnotations;

namespace API.Application.DTO
{
    public class RegistrationPutDto 
    {
        [Required(ErrorMessage = "O userid é obrigatório")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "O group id é obrigatório")]
        public int GroupId { get; set; }

        public DateTime RegistrationDate { get; set; }

        [Required(ErrorMessage = "É obrigatório passar se está ativo")]
        public bool IsActive { get; set; }
    }
}

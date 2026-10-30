using System.ComponentModel.DataAnnotations;

namespace API.Application.DTO
{
    public class ScorePutDto
    {
        [Required]
        public int RegistrationId { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "Value must be between 0 and 10.")]
        public decimal Value { get; set; }

        [Required]
        public bool IsAproved { get; set; }
    }

}
namespace API.Application.DTO
{
    public class ScoreGetDto
    {
        public int Id { get; set; }
        public int RegistrationId { get; set; }
        public decimal Value { get; set; }
        public bool IsAproved { get; set; }
        public bool Excluido { get; set; }
    }

}
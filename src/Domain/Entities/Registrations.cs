namespace API.Domain.Entities
{
    public class Registration
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int GroupId { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsActive { get; set; }

        public User User { get; set; }
        public Group Group { get; set; }

        public ICollection<Score> Scores { get; set; }

    }
}
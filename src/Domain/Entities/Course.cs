namespace API.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<Group> Group { get; set; }

    }

}
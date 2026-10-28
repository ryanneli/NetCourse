namespace API.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool Excluido { get; set; }
        
        public ICollection<Group> Group { get; set; }

    }

}
using System.Runtime.InteropServices;

namespace API.Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public int CourseId { get; set; }

        public bool Excluido { get; set; }
        public ICollection<Registration> Registrations { get; set; }
        public Course Course { get; set; }
    }

}
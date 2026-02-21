using Core.Abstracts.Bases;

namespace Core.Concretes.Entities
{
    public class Skill:BaseEntity
    {
        public string Title { get; set; }
        //public byte Proficiency { get; set; }

        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}

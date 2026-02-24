using Core.Abstracts.Bases;

namespace Core.Concretes.Entities
{
    public class Project:BaseEntity
    {
        public required string Title { get; set; } = null!;
        public required string Description { get; set; } = null!;
        public string? GithubUrl { get; set; }
        //public string ImageUrl { get; set; }

        //Navigation Properties
        //Many-to-Many (Çoka Çok)
        public virtual ICollection<Skill> Skills { get; set; } = [];

    }
}

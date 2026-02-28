using Core.Abstracts.Bases;

namespace Core.Concretes.Entities
{
    public class Skill:BaseEntity
    {
        public required string Title { get; set; } = null!;
        //public byte Proficiency { get; set; }

        #region
        // One-to-Many (Bire Çok)
        //public int ProjectId { get; set; }
        //public virtual Project Project { get; set; }

        //Navigation Properties
        //Many-to-Many (Çoka Çok)
        //public virtual ICollection<Project> Projects { get; set; } = [];
        #endregion
    }
}

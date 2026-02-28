using Core.Abstracts.Bases;
using Core.Concretes.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class CvDbContext : DbContext
    {
        public CvDbContext(DbContextOptions<CvDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }

        #region For Using Many-to-Many, For Using Github
        //Çoka çok ilişki için ara tablo oluşturma
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<ProjectSkill>().HasKey(ps => new { ps.ProjectId, ps.SkillId });
        //    modelBuilder.Entity<Project>().HasMany(p => p.Skills).WithMany(s => s.Projects).UsingEntity<ProjectSkill>();
        //}

        //public class ProjectSkill
        //{
        //public int ProjectId { get; set; }
        //public virtual Project? Project { get; set; }
        //public int SkillId { get; set; }
        //public virtual Skill? Skill { get; set; }
        //}

        //public class Project : BaseEntity
        //{
        //public required string Title { get; set; } = null!;
        //public required string Description { get; set; } = null!;
        //public string? GithubUrl { get; set; }
        //public string ImageUrl { get; set; }
        //Navigation Properties
        //Many-to-Many (Çoka Çok)
        //public virtual ICollection<Skill> Skills { get; set; } = [];
        //}
        #endregion
    }
}

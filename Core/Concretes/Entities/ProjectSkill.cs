namespace Core.Concretes.Entities
{
    public class ProjectSkill
    {
        public int ProjectId { get; set; }
        public virtual Project? Project { get; set; }

        public int SkillId { get; set; }
        public virtual Skill? Skill { get; set; }

    }
}

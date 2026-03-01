using System.ComponentModel.DataAnnotations;

namespace Core.Concretes.DTOs
{
    public class SkillListDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        //public IEnumerable<ProjectSkillDTO> ProjectSkillDTOs { get; set; } = [];
    }
    public class AddSkillDTO
    {
        [Required]
        public string Title { get; set; } = null!;
        //public IEnumerable<ProjectSkillDTO> ProjectSkillDTOs { get; set; } = [];

    }
    public class UpdateSkillDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        //public IEnumerable<ProjectSkillDTO> ProjectSkillDTOs { get; set; } = [];
    }
}

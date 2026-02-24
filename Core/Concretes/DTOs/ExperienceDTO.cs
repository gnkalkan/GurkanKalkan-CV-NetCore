using Core.Concretes.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Concretes.DTOs
{
    public class ExperienceListDTO
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string StartEndYear { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
    public class AddExperienceDTO
    {
        [Required]
        public string CompanyName { get; set; } = null!;
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string StartEndYear { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        public WorkStatus WorkType { get; set; }
    }
    public class UpdateExperienceDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; } = null!;
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string StartEndYear { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        public WorkStatus WorkType { get; set; }
    }
}

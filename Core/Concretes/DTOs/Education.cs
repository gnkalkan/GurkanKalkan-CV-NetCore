using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Concretes.DTOs
{
    public class EducationListDTO
    {
        public int Id { get; set; }
        public string SchoolName { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string StartEndYear { get; set; } = null!;
        public string? Description { get; set; }
    }
    public class AddEducationDTO
    {
        [Required]
        public string SchoolName { get; set; } = null!;
        [Required]
        public string Department { get; set; } = null!;
        [Required]
        public string StartEndYear { get; set; } = null!;
        public string? Description { get; set; }
    }
    public class UpdateEducationDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string SchoolName { get; set; } = null!;
        [Required]
        public string Department { get; set; } = null!;
        [Required]
        public string StartEndYear { get; set; } = null!;
        public string? Description { get; set; }
    }
}

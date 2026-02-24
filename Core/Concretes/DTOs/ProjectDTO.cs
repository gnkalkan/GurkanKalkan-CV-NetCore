using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Concretes.DTOs
{
    public class ProjectListDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? GithubUrl { get; set; }
        public IEnumerable<SkillListDTO> Skills { get; set; } = [];
    }
    public class AddProjectDTO
    {
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        public string? GithubUrl { get; set; }
        public IEnumerable<int> SelectedSkillIds { get; set; } = [];
    }
    public class UpdateProjectDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        public string? GithubUrl { get; set; }
        public IEnumerable<int> SelectedSkillIds { get; set; } = [];
    }
}

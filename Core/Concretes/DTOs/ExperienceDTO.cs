using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Concretes.DTOs
{
    public class ExperienceDTO
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string StartEndYear { get; set; } = null!;
        public string Description { get; set; } = null!;

    }
}

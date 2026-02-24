using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Concretes.Entities
{
    public class Education : BaseEntity
    {
        public required string SchoolName { get; set; } = null!;
        public required string Department { get; set; } = null!;
        public required string StartEndYear { get; set; } = null!;
        public string? Description { get; set; }
    }
}

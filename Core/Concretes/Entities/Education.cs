using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Concretes.Entities
{
    public class Education : BaseEntity
    {
        public string SchoolName { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string StartEndYear { get; set; } = null!;
    }
}

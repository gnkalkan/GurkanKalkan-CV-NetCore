using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Concretes.Entities
{
    public class Personal:BaseEntity
    {
        public required string FullName { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}

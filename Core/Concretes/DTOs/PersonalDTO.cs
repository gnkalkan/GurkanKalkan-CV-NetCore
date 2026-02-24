using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Concretes.DTOs
{
    public class PersonalDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}

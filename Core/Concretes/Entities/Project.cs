using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Concretes.Entities
{
    public class Project:BaseEntity
    {
        public required string Title { get; set; }
        public string Description { get; set; } = null!;
        public string? GithubUrl { get; set; }
        //public string ImageUrl { get; set; }


    }
}

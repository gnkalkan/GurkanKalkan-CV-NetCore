using Core.Abstracts.Bases;

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

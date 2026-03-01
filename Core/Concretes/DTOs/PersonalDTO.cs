using System.ComponentModel.DataAnnotations;

namespace Core.Concretes.DTOs
{
    public class PersonalListDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? ImageUrl { get; set; }
    }
    public class AddPersonalDTO
    {
        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        public string? ImageUrl { get; set; }
    }
    public class UpdatePersonalDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        public string? ImageUrl { get; set; }
    }
    
    
    
    

    

}

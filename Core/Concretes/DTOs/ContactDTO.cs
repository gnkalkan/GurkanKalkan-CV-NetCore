using System.ComponentModel.DataAnnotations;

namespace Core.Concretes.DTOs
{
    public class ContactListDTO
    {
        public int Id { get; set; }
        public string NameSurname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
    public class AddContactDTO
    {
        [Display(Prompt = "FullName"), Required]
        public string NameSurname { get; set; } = null!;
        [EmailAddress, Required, Display(Name ="Email Address", Prompt = "Email Address")]
        public string Email { get; set; } = null!;
        [Display(Name = "Message", Prompt = "Message"), Required, DataType(DataType.MultilineText)]
        public string Message { get; set; } = null!;
    }
    public class UpdateContactDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string NameSurname { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Message { get; set; } = null!;
    }
}

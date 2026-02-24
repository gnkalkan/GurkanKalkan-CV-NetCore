using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
        [Required]
        public string NameSurname { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        [Required]
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

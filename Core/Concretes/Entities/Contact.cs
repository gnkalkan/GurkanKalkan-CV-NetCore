using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Concretes.Entities
{
    public class Contact : BaseEntity
    {
        public required string NameSurname { get; set; } = null!;
        public required string Email { get; set; } = null!;
        public required string Message { get; set; } = null!;
        //public DateTime SendDate { get; set; } = DateTime.Now;
        //public bool IsRead { get; set; }
    }
}

using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Concretes.Entities
{
    public class Contact : BaseEntity
    {
        public required string NameSurname { get; set; }
        public required string Email { get; set; }
        public required string Message { get; set; }
        //public DateTime SendDate { get; set; } = DateTime.Now;
        //public bool IsRead { get; set; }
    }
}

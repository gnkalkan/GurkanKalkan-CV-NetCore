using AutoMapper;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;

namespace Business.Profiles
{
    public class ContactProfiles : Profile
    {
        public ContactProfiles()
        {
            CreateMap<Contact, ContactListDTO>();
            CreateMap<AddContactDTO, Contact>();
            CreateMap<UpdateContactDTO, Contact>();
        }
    }
}

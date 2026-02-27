using AutoMapper;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;

namespace Business.Profiles
{
    public class PersonalProfiles : Profile
    {
        public PersonalProfiles()
        {
            CreateMap<Personal, PersonalListDTO>();
            CreateMap<AddPersonalDTO, Personal>();
            CreateMap<UpdatePersonalDTO, Personal>();
            // .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
        }
    }
}

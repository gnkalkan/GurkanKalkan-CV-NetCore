using AutoMapper;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;

namespace Business.Profiles
{
    public class ExperienceProfiles : Profile
    {
        public ExperienceProfiles()
        {
            CreateMap<Experience, ExperienceListDTO>()
                .ForMember(dest => dest.WorkType, opt => opt.MapFrom(src => src.WorkType.ToString()));
            CreateMap<AddExperienceDTO, Experience>();
            CreateMap<UpdateExperienceDTO, Experience>();
        }
    }
}

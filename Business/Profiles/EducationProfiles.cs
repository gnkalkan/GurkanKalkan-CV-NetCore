using AutoMapper;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;

namespace Business.Profiles
{
    public class EducationProfiles : Profile
    {
        public EducationProfiles()
        {
            CreateMap<Education, EducationListDTO>();
            CreateMap<AddEducationDTO, Education>();
            CreateMap<UpdateEducationDTO, Education>();
        }
    }
}

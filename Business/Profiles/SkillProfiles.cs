using AutoMapper;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;

namespace Business.Profiles
{
    public class SkillProfiles : Profile
    {
        public SkillProfiles()
        {
            CreateMap<Skill, SkillListDTO>();
            CreateMap<AddSkillDTO, Skill>();
            CreateMap<UpdateSkillDTO, Skill>();
        }
    }
}

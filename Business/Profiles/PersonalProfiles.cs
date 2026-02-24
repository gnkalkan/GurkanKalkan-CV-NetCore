using AutoMapper;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Profiles
{
    public class PersonalProfiles:Profile
    {
        public PersonalProfiles()
        {
            CreateMap<Personal, PersonalListDTO>();
            // .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
        }
    }
}

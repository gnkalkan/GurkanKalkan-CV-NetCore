using AutoMapper;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;

namespace Business.Profiles
{
    public class ProjectProfiles : Profile
    {
        public ProjectProfiles()
        {
            CreateMap<Project, ProjectListDTO>();
            CreateMap<AddProjectDTO, Project>();
            CreateMap<UpdateProjectDTO, Project>();
        }
    }
}

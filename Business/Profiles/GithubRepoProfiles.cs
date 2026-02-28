using AutoMapper;
using Core.Concretes.DTOs;
using Octokit;

namespace Business.Profiles
{
    public class GithubRepoProfiles : Profile
    {
        public GithubRepoProfiles()
        {
            CreateMap<Repository, GithubRepoListDTO>();
        }
    }
}

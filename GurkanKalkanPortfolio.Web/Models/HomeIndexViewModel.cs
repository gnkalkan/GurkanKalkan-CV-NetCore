using Core.Concretes.DTOs;

namespace GurkanKalkanPortfolio.Web.Models
{
    public class HomeIndexViewModel
    {
        public PersonalListDTO Personal { get; set; } = null!;
        public IEnumerable<SkillListDTO> Skills { get; set; } = null!;
        public IEnumerable<ExperienceListDTO> Experiences { get; set; } = null!;
        public IEnumerable<GithubRepoListDTO> GithubRepositories { get; set; } = null!;
    }
}

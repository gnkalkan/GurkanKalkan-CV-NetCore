using Core.Concretes.DTOs;

namespace GurkanKalkanPortfolio.Web.Models
{
    public class HomeIndexViewModel
    {
        public PersonalListDTO Personal { get; set; } = null!;
        public IEnumerable<SkillListDTO> Skills { get; set; } = [];
        public IEnumerable<ExperienceListDTO> Experiences { get; set; } = [];
        public IEnumerable<GithubRepoListDTO> GithubRepositories { get; set; } = [];
        public AddContactDTO Contact { get; set; } = null!;
    }
}

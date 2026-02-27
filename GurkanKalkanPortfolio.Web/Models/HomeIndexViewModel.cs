using Core.Concretes.DTOs;

namespace GurkanKalkanPortfolio.Web.Models
{
    public class HomeIndexViewModel
    {
        public PersonalListDTO Personal { get; set; }
        public IEnumerable<SkillListDTO> Skills { get; set; }
}
}

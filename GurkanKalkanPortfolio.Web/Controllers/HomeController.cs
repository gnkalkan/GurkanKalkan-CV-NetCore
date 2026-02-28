using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using GurkanKalkanPortfolio.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace GurkanKalkanPortfolio.Web.Controllers
{
    public class HomeController(IPersonalService personalService, ISkillService skillService, IExperienceService experienceService, IGithubService githubService, IContactService contactService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var personalModel = await personalService.GetByIdAsync(1);
            var skillModel = await skillService.GetAllAsync();
            var experienceModel = await experienceService.GetAllAsync();
            var githubModel = await githubService.GetRepositoriesAsync();
            

            if (personalModel.Success && skillModel.Success)
            {
                var viewModel = new HomeIndexViewModel
                {
                    Personal = personalModel.Data,
                    Skills = skillModel.Data,           
                    Experiences = experienceModel.Data,
                    GithubRepositories = githubModel.Data
                };
                return View(viewModel);
            }
            return Problem("Veriler yüklenirken hata oluþtu.");
                
        }
        public IActionResult DownloadCv()
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "docs", "GurkanKalkan_CV.pdf");
            if (!System.IO.File.Exists(filepath))
            {
                return Problem("CV dosyasý bulunamadý.");
            }

            return PhysicalFile(filepath, "application/pdf", "GurkanKalkan_CV.pdf");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactAdd(AddContactDTO Contact)
        {
            if (ModelState.IsValid)
            { 
                var result = await contactService.AddAsync(Contact);
                if (result.Success)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty, result.Message);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}

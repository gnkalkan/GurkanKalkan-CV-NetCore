using AutoMapper;
using Core.Abstracts.IServices;
using GurkanKalkanPortfolio.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Octokit;


namespace GurkanKalkanPortfolio.Web.Controllers
{
    public class HomeController(IPersonalService personalService, ISkillService skillService, IExperienceService experienceService, IGithubService githubService) : Controller
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
    }
}

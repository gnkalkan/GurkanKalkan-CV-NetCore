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
            //var client = new GitHubClient(new ProductHeaderValue("GurkanKalkanPortfolio"));
            //var repos = await client.Repository.GetAllForUser("gnkalkan");
            

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
                
                //return View(model.Data);
                // Eðer Bulunamadý Sayfan varsa bu kodu kullanabilirsin.
                //if (model.Data == null || !model.Data.Any())
                //    return View(model.Data);
                //else 
                //    return NotFound();
                
            }
                return Problem("Veriler yüklenirken hata oluþtu.");
                
        }
    }
}

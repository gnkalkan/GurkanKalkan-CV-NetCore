using Core.Abstracts.IServices;
using GurkanKalkanPortfolio.Web.Models;
using Microsoft.AspNetCore.Mvc;


namespace GurkanKalkanPortfolio.Web.Controllers
{
    public class HomeController(IPersonalService personalService, ISkillService skillService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var personalModel = await personalService.GetByIdAsync(1);
            var skillModel = await skillService.GetAllAsync();
            if (personalModel.Success && skillModel.Success)
            {

                var viewModel = new HomeIndexViewModel
                {
                    Personal = personalModel.Data,
                    Skills = skillModel.Data
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

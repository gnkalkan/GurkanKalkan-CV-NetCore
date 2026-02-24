using Core.Abstracts.IServices;
using GurkanKalkanPortfolio.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GurkanKalkanPortfolio.Web.Controllers
{
    public class HomeController(IPersonalService personalService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await personalService.GetAllAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

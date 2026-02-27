using Core.Abstracts.IServices;
using Microsoft.AspNetCore.Mvc;


namespace GurkanKalkanPortfolio.Web.Controllers
{
    public class HomeController(IPersonalService service) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = await service.GetAllAsync();
            if (model.Success)
            {
                return View(model.Data);
                // Eðer Bulunamadý Sayfan varsa bu kodu kullanabilirsin.
                //if (model.Data == null || !model.Data.Any())
                //    return View(model.Data);
                //else 
                //    return NotFound();
                
            }
            else
            {
                return Problem(model.Message);
            }
                
        }
    }
}

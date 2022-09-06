using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}

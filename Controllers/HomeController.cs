using Microsoft.AspNetCore.Mvc;

namespace Shuttle_Security_V_Lite.Controllers
{
    public class HomeController : Controller
    {
       
        
        public IActionResult Index()
        {
            return View();
        }
    }
}

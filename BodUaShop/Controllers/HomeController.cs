using Microsoft.AspNetCore.Mvc;

namespace BodUaShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

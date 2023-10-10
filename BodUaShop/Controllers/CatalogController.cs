using Microsoft.AspNetCore.Mvc;

namespace BodUaShop.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

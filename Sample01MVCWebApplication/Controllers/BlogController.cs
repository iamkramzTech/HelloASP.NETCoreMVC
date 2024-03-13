using Microsoft.AspNetCore.Mvc;

namespace Sample01MVCWebApplication.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

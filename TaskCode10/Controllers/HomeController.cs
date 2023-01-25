using Microsoft.AspNetCore.Mvc;

namespace TaskCode10.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

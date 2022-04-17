using Microsoft.AspNetCore.Mvc;

namespace SmallTask.Controllers
{
    public class HelloPashaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

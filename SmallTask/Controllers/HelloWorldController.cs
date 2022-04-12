using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using SmallTask.Models;

namespace SmallTask.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
                return View("Welcome", user);
            else
                return View();
        }

        public IActionResult Welcome(string name, int ID = 1)
        {
            return View();
        }
    }
}

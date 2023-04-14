using Microsoft.AspNetCore.Mvc;

namespace Blazor.Controller
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

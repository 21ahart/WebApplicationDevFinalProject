using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDevFinalProject.Controllers
{
    public class Top100Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

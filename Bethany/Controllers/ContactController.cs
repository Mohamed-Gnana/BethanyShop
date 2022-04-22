using Microsoft.AspNetCore.Mvc;

namespace Bethany.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

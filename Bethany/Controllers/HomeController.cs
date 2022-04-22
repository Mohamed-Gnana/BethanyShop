using Bethany.Models;
using Bethany.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bethany.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            var homeListViewModel = new HomeListViewModel(_pieRepository.PiesOfTheWeek);
            return View(homeListViewModel);
        }
    }
}

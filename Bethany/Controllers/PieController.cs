using Bethany.Models;
using Bethany.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Bethany.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string Category)
        {
            ViewBag.Title = "Pie's List";
            string currentCategory;
            IEnumerable<Pie> pies;
            if (string.IsNullOrEmpty(Category))
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                currentCategory = "All Pies";
            }
            else
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == Category).OrderBy(p => p.PieId);
                currentCategory = Category;
            }
            return View(new PiesListViewModel
            {
                CurrentCategory = currentCategory,
                Pies = pies
            });
        }

        public IActionResult Details(int id)
        {
            Pie pie = _pieRepository.GetPieById(id);
            if(pie == null)
            {
                return NotFound();
            }
            ViewBag.Title = pie.Name;
            return View(pie);
        }
    }
}

using Bethany.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Bethany.Components
{
    public class MenuCategories: ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public MenuCategories(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var Categories = _categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(Categories);
        }
    }
}

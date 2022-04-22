using Bethany.Models;

namespace Bethany.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }

        public PiesListViewModel(IEnumerable<Pie> pies = null, string currentCategory = "")
        {
            Pies = pies;
            CurrentCategory = currentCategory;
        }
    }
}

using Bethany.Models;

namespace Bethany.ViewModels
{
    public class HomeListViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
        public HomeListViewModel(IEnumerable<Pie> pies = null)
        {
            PiesOfTheWeek = pies;
        }
    }
}

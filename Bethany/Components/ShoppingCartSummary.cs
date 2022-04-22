using Bethany.Models;
using Bethany.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bethany.Components
{
    public class ShoppingCartSummary: ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        public IViewComponentResult Invoke()
        {
            var Items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = Items;

            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel); 
        }
    }
}

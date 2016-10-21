using System;
using System.Linq;

namespace PotterShoppingCart.Logistic
{
    public class TwoDifferentBook : IBook
    {
        public TwoDifferentBook()
        {
        }

        public double CalculateFee(ShoppingCart shoppingCart)
        {
            return shoppingCart.Books.Distinct().Count() * 100 * 0.95;
        }
    }
}
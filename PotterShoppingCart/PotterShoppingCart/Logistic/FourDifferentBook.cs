using System;

namespace PotterShoppingCart.Logistic
{
    public class FourDifferentBook : IBook
    {
        public double CalculateFee(ShoppingCart shoppingCart)
        {
            return shoppingCart.Books.Count * 100 * 0.8;
        }
    }
}
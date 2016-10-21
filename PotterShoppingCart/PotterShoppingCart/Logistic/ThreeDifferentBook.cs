using System;

namespace PotterShoppingCart.Logistic
{
    public class ThreeDifferentBook : IBook
    {
        public ThreeDifferentBook()
        {
        }

        public double CalculateFee(ShoppingCart shoppingCart)
        {
            return shoppingCart.Books.Count * 100 * 0.9;
        }
    }
}
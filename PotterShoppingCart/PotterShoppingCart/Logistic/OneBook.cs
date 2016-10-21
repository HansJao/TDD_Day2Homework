using System;

namespace PotterShoppingCart.Logistic
{
    public class OneBook : IBook
    {
        public OneBook()
        {
        }

        public double CalculateFee(ShoppingCart shoppingCart)
        {
            return shoppingCart.Books.Count * 100;
        }
    }
}
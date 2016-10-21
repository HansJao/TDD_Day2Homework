using PotterShoppingCart.Logistic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class BookStore
    {
        private ShoppingCart shoppingCart;

        public BookStore(ShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }

        public double CountTotalPay()
        {
            IBook book = GetBook();
            shoppingCart.Fee = book.CalculateFee(shoppingCart);

            return shoppingCart.Fee;
        }

        private IBook GetBook()
        {
            if (shoppingCart.Books.Count == 1)
            {
                return new OneBook();
            }
            else if (shoppingCart.Books.Distinct().Count() == 2 && shoppingCart.Books.Count == 2)
            {
                return new TwoDifferentBook();
            }
            else if (shoppingCart.Books.Distinct().Count() == 3 && shoppingCart.Books.Count == 3)
            {
                return new ThreeDifferentBook();
            }
            return null;
        }
    }

    public class ShoppingCart
    {
        public List<string> Books { get; set; }
        public double Fee { get; set; }
    }

}

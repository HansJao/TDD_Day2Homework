using PotterShoppingCart.Logistic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class BookStore
    {
        private ShoppingCart _shoppingCart;

        public BookStore(ShoppingCart shoppingCart)
        {
            this._shoppingCart = shoppingCart;
        }

        public double CountTotalPay()
        {

            IBook book = GetBook(_shoppingCart);
            _shoppingCart.Fee = book.CalculateFee(_shoppingCart);
            return _shoppingCart.Fee;
        }

        private IBook GetBook(ShoppingCart shoppingCart)
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
            else if (shoppingCart.Books.Distinct().Count() == 4 && shoppingCart.Books.Count == 4)
            {
                return new FourDifferentBook();
            }
            else if (shoppingCart.Books.Distinct().Count() == 5 && shoppingCart.Books.Count == 5)
            {
                return new FiveDifferentBook();
            }
            else
            {
                return new OtherBookOrder();
            }
        }
    }

    public class ShoppingCart
    {
        public List<string> Books { get; set; }
        public double Fee { get; set; }
    }

}

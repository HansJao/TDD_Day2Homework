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

            if (shoppingCart.Books.Count == 1)
            {
                return shoppingCart.Books.Count * 100;
            }
            else if (shoppingCart.Books.Distinct().Count() == 2 && shoppingCart.Books.Count == 2)
            {
                return shoppingCart.Books.Distinct().Count() * 100 * 0.95;
            }
            else if (shoppingCart.Books.Distinct().Count() == 3 && shoppingCart.Books.Count == 3)
            {
                return shoppingCart.Books.Distinct().Count() * 100 * 0.9;
            }
            return 0;
        }
    }

    public class ShoppingCart
    {
        public List<string> Books { get; set; }
        public double Fee { get; set; }
    }

}

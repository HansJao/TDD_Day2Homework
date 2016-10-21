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
                return shoppingCart.Books.Count * 100;
            else
                return 0;
        }
    }

    public class ShoppingCart
    {
        public List<string> Books { get; set; }
        public double Fee { get; set; }
    }

}

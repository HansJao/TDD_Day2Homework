using System;
using PotterShoppingCart.Logistic;
using System.Linq;
using System.Collections.Generic;

namespace PotterShoppingCart.Logistic
{
    class OtherBookOrder : IBook
    {
        public double CalculateFee(ShoppingCart shoppingCart)
        {
            var remainBook = new ShoppingCart
            {
                Books = new List<string>()
            };
            remainBook.Books = shoppingCart.Books;

            while ( shoppingCart.Books.Distinct().Count()>0)
            {
                shoppingCart.Books = shoppingCart.Books.Distinct().ToList();

                BookStore book = new BookStore(shoppingCart);
                remainBook.Fee += book.CountTotalPay();
                foreach (string i in shoppingCart.Books)
                {
                    remainBook.Books.RemoveAt(remainBook.Books.IndexOf(i));
                }
                shoppingCart.Books = remainBook.Books;
            }
            return remainBook.Fee;
        }
    }
}
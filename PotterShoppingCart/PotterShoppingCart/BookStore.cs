using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class BookStore
    {
        public BookStore(IList<ShoppingCart> Books)
        {
                
        }

        public double CountTotalPay()
        {
            throw new NotImplementedException();
        }
    }

    public class ShoppingCart
    {
        public string Book { get; set; }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class BookStoreTests
    {
        [TestMethod()]
        public void Test_ShoppingCart_Buy_1Book_Should_Pay_100()
        {
            List<ShoppingCart> shoppingCart = new List<ShoppingCart>
            {
                new ShoppingCart {Book="Book1" }
            };

            var target = new BookStore(shoppingCart);
            
            double Actual = target.CountTotalPay();
            double expected = 100;

            Assert.AreEqual(expected,100);
        }
    }
}
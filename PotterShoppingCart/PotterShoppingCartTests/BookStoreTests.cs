﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var Books = new ShoppingCart
            {
                Books = new List<string> { "Book1"}
            };
            

            var target = new BookStore(Books);

            double Actual = target.CountTotalPay();
            double expected = 100;

            Assert.AreEqual(expected, Actual);
        }

        [TestMethod()]
        public void Test_ShoppingCart_Buy_2Book_Should_Pay_190()
        {
            var Books = new ShoppingCart
            {
                Books = new List<string> { "Book1","Book2" }
            };


            var target = new BookStore(Books);

            double Actual = target.CountTotalPay();
            double expected = 190;

            Assert.AreEqual(expected, Actual);
        }
    }
}
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
        [TestMethod()]
        public void Test_ShoppingCart_Buy_3Books_Should_Pay_270()
        {
            var Books = new ShoppingCart
            {
                Books = new List<string> { "Book1", "Book2","Book3" }
            };


            var target = new BookStore(Books);

            double Actual = target.CountTotalPay();
            double expected = 270;

            Assert.AreEqual(expected, Actual);
        }
        [TestMethod()]
        public void Test_ShoppingCart_Buy_4Books_Should_Pay_320()
        {
            var Books = new ShoppingCart
            {
                Books = new List<string> { "Book1", "Book2", "Book3","Book4" }
            };


            var target = new BookStore(Books);

            double Actual = target.CountTotalPay();
            double expected = 320;

            Assert.AreEqual(expected, Actual);
        }
        [TestMethod()]
        public void Test_ShoppingCart_Buy_5Books_Should_Pay_375()
        {
            var Books = new ShoppingCart
            {
                Books = new List<string> { "Book1", "Book2", "Book3", "Book4","Book5" }
            };


            var target = new BookStore(Books);

            double Actual = target.CountTotalPay();
            double expected = 375;

            Assert.AreEqual(expected, Actual);
        }

        [TestMethod()]
        public void Test_ShoppingCart_Buy_4Books_And_One_Same_Should_Pay_370()
        {
            var Books = new ShoppingCart
            {
                Books = new List<string> { "Book1", "Book2", "Book3", "Book3" }
            };


            var target = new BookStore(Books);

            double Actual = target.CountTotalPay();
            double expected = 370;

            Assert.AreEqual(expected, Actual);
        }

        [TestMethod()]
        public void Test_ShoppingCart_Buy_5Books_And_Two_Same_Should_Pay_460()
        {
            var Books = new ShoppingCart
            {
                Books = new List<string> { "Book1", "Book2", "Book3", "Book3","Book2" }
            };


            var target = new BookStore(Books);

            double Actual = target.CountTotalPay();
            double expected = 460;

            Assert.AreEqual(expected, Actual);
        }
    }
}
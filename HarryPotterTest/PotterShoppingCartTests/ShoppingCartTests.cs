using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotterShoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()] 
        public void 第一集買一本_價格應為100元()
        {
            List<Book> order = new List<Book>()
            {
                new Book{Episode=1}
            };

            var target = new ShoppingCart();
            var expected = 100;
            var actual = target.Checkout(order);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一二集各買一本_價格應為190元()
        {
            List<Book> order = new List<Book>()
            {
                new Book{Episode=1},
                new Book{Episode=2}
            };

            var target = new ShoppingCart();
            var expected = 190;
            var actual = target.Checkout(order);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一二三集各買一本_價格應為270元()
        {
            List<Book> order = new List<Book>()
            {
                new Book{Episode=1},
                new Book{Episode=2},
                new Book{Episode=3}
            };

            var target = new ShoppingCart();
            var expected = 270;
            var actual = target.Checkout(order);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一二三四集各買一本_價格應為320元()
        {
            List<Book> order = new List<Book>()
            {
                new Book{Episode=1},
                new Book{Episode=2},
                new Book{Episode=3},
                new Book{Episode=4}
            };

            var target = new ShoppingCart();
            var expected = 320;
            var actual = target.Checkout(order);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一二三四五集各買一本_價格應為375元()
        {
            List<Book> order = new List<Book>()
            {
                new Book{Episode=1},
                new Book{Episode=2},
                new Book{Episode=3},
                new Book{Episode=4},
                new Book{Episode=5}
            };

            var target = new ShoppingCart();
            var expected = 375;
            var actual = target.Checkout(order);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一二集各買一本_第三集買兩本_價格應為370元()
        {
            List<Book> order = new List<Book>()
            {
                new Book{Episode=1},
                new Book{Episode=2},
                new Book{Episode=3},
                new Book{Episode=3}
            };

            var target = new ShoppingCart();
            var expected = 370;
            var actual = target.Checkout(order);
            Assert.AreEqual(expected, actual);
        }
    }
}

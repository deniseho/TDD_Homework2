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
    }
}

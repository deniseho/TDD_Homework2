using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        public double Checkout(List<Book> order)
        {
            var orderCount = order.Count();
            var bookPrice = new Book().Price;
            return orderCount * bookPrice;
        }
    }
}

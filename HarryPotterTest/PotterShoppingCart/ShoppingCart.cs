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

            var discount = GetDiscount(orderCount);

            var bookPrice = new Book().Price;

            return orderCount * bookPrice * discount;
        }

        private double GetDiscount(int orderCount)
        {
            switch (orderCount)
            {
                case 1:
                    goto default;
                case 2:
                    return 0.95;
                case 3:
                    return 0.9;
                default:
                    return 1;
            }
        }
    }
}

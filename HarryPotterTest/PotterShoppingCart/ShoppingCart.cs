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
            var distinctEpisodeCount = order.GroupBy(x => x.Episode).Count();

            var discount = GetDiscount(distinctEpisodeCount);
            var duplicateEpisodes = CheckDuplicate(orderCount, distinctEpisodeCount);

            var bookPrice = new Book().Price;
            var total = bookPrice * distinctEpisodeCount * discount + duplicateEpisodes * bookPrice;
            
            return total;
        }

        private int CheckDuplicate(int orderCount, int distinctEpisodeCount)
        {
            if (orderCount == distinctEpisodeCount)
                return 0;
            else
                return orderCount - distinctEpisodeCount;
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
                case 4:
                    return 0.8;
                case 5:
                    return 0.75;
                default:
                    return 1;
            }
        }
    }
}

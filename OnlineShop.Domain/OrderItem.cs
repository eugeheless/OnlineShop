using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public Order Order { get; set; }
        public Item Item { get; set; }
    }
}

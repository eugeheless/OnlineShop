using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class Item
    {
        public Item()
        {
            Orders = new HashSet<OrderItem>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }


        public virtual ICollection<OrderItem> Orders { get; set; }
    }
}

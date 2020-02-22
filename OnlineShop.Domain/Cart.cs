using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class Cart
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }

        
        
        
        
        
        public int OrderId { get; set; }
        public Order Order { get; set; } //Навиг свойство






        public List<Item> Item { get; set; }
    }
}

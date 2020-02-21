using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class Order
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string OrderDate { get; set; }
        public string DoneDate { get; set; }

    }
}

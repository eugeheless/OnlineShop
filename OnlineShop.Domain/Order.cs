using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class Order
    {
        public Order()
        {
            Items = new HashSet<OrderItem>();
        }
        public int Id { get; set; }
        public string OrderDate { get; set; }
        public string DoneDate { get; set; }


        public int ClientID { get; set; }//Навиг свойство
        public Client Client { get; set; } //к клиенту


        public virtual ICollection<OrderItem> Items { get; set; }


    }
}

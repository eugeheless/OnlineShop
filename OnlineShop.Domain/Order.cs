using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientID { get; set; }
        public string OrderDate { get; set; }
        public string DoneDate { get; set; }
        public Client Client { get; set; } //Навигационное свойство



        public Cart Cart { get; set; }

    }
}

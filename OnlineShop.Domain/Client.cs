using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Domain
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
    }
}

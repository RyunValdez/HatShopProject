﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class Merchandise : Item
    {
        public Merchandise(string rif_ID, string name, decimal price, int quantity, string description)
        {
            this.RIF_ID = rif_ID;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Description = description;
        }
    }
}

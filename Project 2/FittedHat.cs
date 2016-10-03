using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class FittedHat : Hat
    {

        public string Size { get; set; }

        public FittedHat (string rif_ID, string name, decimal price, int quantity, string description, string size)
        {
            this.RIF_ID = rif_ID;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Description = description;
            this.Size = size;
        }
    }
}

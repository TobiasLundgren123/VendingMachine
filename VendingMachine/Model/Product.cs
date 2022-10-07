using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    public abstract class Product
    {

        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        protected Product(string name, int price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public abstract void Examine();
        public abstract void Use();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    internal class Drink : Product
    {
        public string description { get; set; }
        public string usage { get; set; }
        public Drink(string name, int price, int stock) : base(name, price, stock)
        {
        }

        public override void Examine()
        {
            Console.WriteLine("{1} - {0}. {1} has price {2} and there are {3} items remaining", this.description, this.Name, this.Price, this.Stock);
        }

        public override void Use()
        {
            Console.WriteLine("{0} - {1}", this.Name, this.usage);
        }

        public override string? ToString()
        {
            return string.Format("{1} - {0}. {1} has price {2}", this.description, this.Name, this.Price);
        }
    }
}

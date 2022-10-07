using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    internal class Drink : Product
    {

        public Drink(string name, int price, int stock) : base(name, price, stock)
        {
        }

        public override void Examine()
        {
            Console.WriteLine(this.Name + " has price {0} and there are {1} items remaining", this.Price, this.Stock);
        }

        public override void Use()
        {
            throw new NotImplementedException();
        }



    }
}

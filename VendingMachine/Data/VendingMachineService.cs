using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.Data
{
    internal class VendingMachineService : IVending
    {
        private int money;

        public VendingMachineService(int money)
        {
            this.money = money;
        }

        public void Details()
        {
            Console.WriteLine("Current saldo is: ");
        }

        public void EndTransaction()
        {
            Console.WriteLine("Withdrawing " + this.money);
            this.money = 0;
            
        }

        public void InsertMoney(int amount)
        {
            this.money += amount;
            
        }


        public void Purchase(Product product)
        {
            if(product.Stock <= 0)
            { Console.WriteLine("Sorry, that item is out of stock"); }

            else if (this.money < product.Price)
            {
                Console.WriteLine("Sorry, you do not have the funds for this purchase. Please insert more money");
            } else
            {
                Console.WriteLine("Purchasing " + product.Name);
                this.money -= product.Price;
                product.Stock -= 1;
            }
            
        }

        public void ShowAll()
        {
            throw new NotImplementedException();
        }
    }
}

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
        private int[] moneyDenominations;
        private List<Product> products;

        public VendingMachineService(int money)
        {
            this.money = money;
            moneyDenominations = new int[8] {1, 5, 10, 20, 50, 100, 500, 1000} ;
            this.products = new List<Product>();
        }

        public void Saldo()
        {
            Console.WriteLine("Current saldo is: " + this.money);
        }

        public void Details(Product product)
        {
            Console.WriteLine(product);
        }

        public void EndTransaction()
        {
            Console.WriteLine("Withdrawing " + this.money);
            this.money = 0;
            //Not sure how to use Dictionary here
        }

        public void InsertMoney(int amount)
        {
            //if(Array.Exists(moneyDenominations,amount)
            foreach(var money in moneyDenominations)
            {
                if (money == amount)
                {
                    this.money += amount;
                }
            }
            
            
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
            foreach(Product product in this.products)
            { Console.WriteLine(product); }
        }
    }
}

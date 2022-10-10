using VendingMachine.Data;
using VendingMachine.Model;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product drink1 = new Drink("Bubbel", 23, 2);
            Drink drink2 = new Drink("Orange", 11, 4);
            Drink drink3 = new Drink("Binge", 1, 33);
            drink2.description = "Orange flavour";
            drink3.description = "Bingy";
            drink2.usage = "Put it to your mouth and slurp";

            VendingMachineService wendy = new VendingMachineService(1);

            wendy.InsertMoney(21);
            wendy.InsertMoney(16);
            wendy.InsertMoney(1);

            wendy.InsertMoney(10);

            wendy.InsertMoney(100);
            wendy.Saldo();
            wendy.Purchase(drink1);
            wendy.Purchase(drink2);
            wendy.Purchase(drink1);
            wendy.Purchase(drink1);
            drink1.Examine();
            drink2.Examine();
            drink3.Examine();
            drink2.Use();
            Console.WriteLine(drink1);
            wendy.Details(drink1);
            wendy.Details(drink2);
            wendy.Details(drink3);
            
            wendy.ShowAll();

        }
    }
}
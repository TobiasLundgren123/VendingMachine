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

            VendingMachineService wendy = new VendingMachineService(1);
            wendy.InsertMoney(21);
            wendy.InsertMoney(16);
            wendy.Purchase(drink1);
            wendy.Purchase(drink2);
            wendy.Purchase(drink1);
            wendy.Purchase(drink1);
            drink1.Examine();
            drink2.Examine();
            drink3.Examine();
        }
    }
}
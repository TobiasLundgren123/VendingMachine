using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    public interface IVending
    {
        void Purchase(Product product);
        void ShowAll();
        void Details(Product product);
        void InsertMoney(int amount);
        void EndTransaction();
    }
}

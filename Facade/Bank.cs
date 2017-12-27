using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Bank
    {
        public bool HasSufficientSavings(Customer customer, int ammount)
        {
            Console.WriteLine("Check bank for ", customer.Name);
            return true;
        }
    }
}

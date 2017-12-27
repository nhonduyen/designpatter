using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Loan
    {
        public bool HasNoBadLoad(Customer customer)
        {
            Console.WriteLine("Check loan for ", customer.Name);
            return true;
        }
    }
}

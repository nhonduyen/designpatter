using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Mortgage
    {
        private Bank bank = new Bank();
        private Loan loan = new Loan();
        private Credit credit = new Credit();

        public bool IsEligible(Customer customer, int ammount)
        {
            Console.WriteLine("{0} applies for {1}", customer.Name, ammount);
           
            if (!bank.HasSufficientSavings(customer, ammount))
                return false;
            if (!loan.HasNoBadLoad(customer))
                return false;
            if (!credit.HasGoodCredit(customer))
                return false;
            return true;
        }
    }
}

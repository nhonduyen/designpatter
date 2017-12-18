using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pepsi:ColdDrink
    {
        public override float price()
        {
            return 35;
        }
        public override string name()
        {
            return "Pepsi";
        }
    }
}

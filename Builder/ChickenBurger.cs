using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ChickenBurger:Burger
    {
        public override float price()
        {
            return 50;
        }
        public override string name()
        {
            return "chicken burger";
        }
    }
}

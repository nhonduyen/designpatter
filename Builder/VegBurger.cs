using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class VegBurger:Burger
    {
        public override float price()
        {
            return 25;
        }
        public override string name()
        {
            return "veg burger";
        }
    }
}

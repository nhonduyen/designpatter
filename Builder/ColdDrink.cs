using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class ColdDrink:Item
    {
        public Packing packing()
        {
            return new Bottle();
        }
        public abstract float price();
        public abstract string name();
    }
}

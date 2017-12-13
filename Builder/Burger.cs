using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Burger:Item
    {
        public Packing packing()
        {
            return new Wrapper();
        }
        public abstract float price();
        public abstract string name();
    }
}

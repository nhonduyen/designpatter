using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface Item
    {
        string name();
        Packing packing();
        float price();
    }
}

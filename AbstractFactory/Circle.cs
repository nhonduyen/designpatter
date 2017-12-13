using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Circle:Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw circle");
        }
    }
}

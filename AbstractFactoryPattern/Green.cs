using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Green:Color
    {
        public void fill()
        {
            Console.WriteLine("Inside Green:fill() method");
        }
    }
}

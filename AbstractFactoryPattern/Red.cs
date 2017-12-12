using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Red:Color
    {
        public void fill()
        {
            Console.WriteLine("Inside Red:fill() method");
        }
    }
}

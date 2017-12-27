using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RedCircle:DrawApi
    {
        public void drawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Draw circle [Color: red, Radius {0}, x {1}, y {2}", radius,x,y);
        }
    }
}

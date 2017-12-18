using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle:Shape
    {
        public Circle()
        {
            this.type = "Circle";
        }

        public override void draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}

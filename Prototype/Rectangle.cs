using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Rectangle:Shape
    {
        public Rectangle()
        {
            this.type = "Rectangle";
        }

        public override void draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }
}

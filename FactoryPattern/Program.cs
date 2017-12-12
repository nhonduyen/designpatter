using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();
            var square = factory.getShape("square");
            square.draw();
            var rectangle = factory.getShape("rectangle");
            rectangle.draw();
            var circle = factory.getShape("circle");
            circle.draw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = FactoryProducer.getFactory("shape");
            var circle = shapeFactory.getShape("circle");
            circle.draw();

            var colorFactory = FactoryProducer.getFactory("color");
            var red = colorFactory.getColor("red");
            red.fill();
        }
    }
}

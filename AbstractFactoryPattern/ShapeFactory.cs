using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ShapeFactory:AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
                return null;
            switch (shapeType.ToUpper())
            {
                case "RECTANGLE":
                    return new Rectangle();
                case "SQUARE":
                    return new Square();
                case "CIRCLE":
                    return new Circle();
            }
            return null;
        }
        public override Color getColor(string color)
        {
            return null;
        }
    }
}

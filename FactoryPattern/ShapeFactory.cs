using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public Shape getShape(string shapeType)
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
    }
}

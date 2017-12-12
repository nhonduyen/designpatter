using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ColorFactory:AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
            return null;
        }
        public override Color getColor(string color)
        {
            if (string.IsNullOrEmpty(color))
                return null;
            switch (color.ToUpper())
            {
                case "RED":
                    return new Red();
                case "GREEN":
                    return new Green();
                case "BLUE":
                    return new Blue();
            }
            return null;
        }
    }
}

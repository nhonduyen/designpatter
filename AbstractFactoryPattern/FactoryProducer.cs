using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(string choice)
        {
            if (string.IsNullOrEmpty(choice))
                return null;
            switch (choice.ToUpper())
            {
                case "SHAPE":
                    return new ShapeFactory();
                case "COLOR":
                    return new ColorFactory();
            }
            return null;
        }
    }
}

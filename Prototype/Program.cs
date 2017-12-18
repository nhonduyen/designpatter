using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.loadCache();
            foreach (var shape in ShapeCache.shapeMap)
            {
                Shape cloneShape = shape.Value;
                Console.WriteLine("Shape: {0}, id: {1}", cloneShape.getType(), shape.Key);
            }
          
        }
    }
}

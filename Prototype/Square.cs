using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Square:Shape
    {
        public Square()
        {
            this.type = "Quare";
        }

        public override void draw()
        {
            Console.WriteLine("Draw square");
        }
    }
}

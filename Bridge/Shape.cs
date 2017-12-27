using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Shape
    {
        protected DrawApi drawApi;

        protected Shape(DrawApi drawApi)
        {
            this.drawApi = drawApi;
        }
        public abstract void draw();
    }
}

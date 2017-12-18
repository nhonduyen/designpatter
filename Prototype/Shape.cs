using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Shape:ICloneable
    {
        private int id;
        protected string type;

        abstract public void draw();

        public string getType()
        {
            return this.type;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public object Clone()
        {
            object clone = null;

            try
            {
                clone = this.MemberwiseClone();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return clone;
        }
    }
}

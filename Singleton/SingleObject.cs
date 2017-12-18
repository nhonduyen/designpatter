using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingleObject
    {
        private static SingleObject instance = new SingleObject();

        private SingleObject() { }

        public static SingleObject getInstance()
        {
            if (instance == null)
                instance = new SingleObject();
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}

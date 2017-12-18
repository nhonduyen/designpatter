using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Meal
    {
        private ArrayList items = new ArrayList();

        public void addItem(Item item)
        {
            items.Add(item);
        }

        public float getCost()
        {
            float cost = 0;
            foreach (Item item in items)
            {
                cost += item.price();
            }
            return cost;
        }
        public void showItems()
        {
            foreach (Item item in items)
            {
                Console.WriteLine("Item : ", item.name());
                Console.WriteLine("Packing : ", item.packing().pack());
                Console.WriteLine("Price : ", item.price());
               
            }
        }
    }
}

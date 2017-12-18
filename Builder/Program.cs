using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mb = new MealBuilder();
            Console.WriteLine("Veg meal");
            Meal VegMeal = mb.prepareVegMeal();
            Console.WriteLine("Cost: ", VegMeal.getCost());
            Console.WriteLine("Non Veg meal");
            Meal m = mb.prepareNonVegMeal();
            Console.WriteLine("Cost: ", m.getCost());
        }
    }
}

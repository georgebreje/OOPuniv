using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal();
            Food farmfood = new Food();

            cow.Eat(FoodType.Hay, farmfood);

            Console.WriteLine(farmfood.HayQ);
        }
    }
}

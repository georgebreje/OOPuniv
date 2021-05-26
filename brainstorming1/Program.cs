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
            // natural reserve

            Bear bearone = new Bear();
            Bear beartwo = new Bear();
            Bear bearthree = new Bear();

            Food forestFood = new Food();
            Habitat forestArieseni = new Forest();

            forestArieseni.Bring(bearone);
            forestArieseni.Bring(beartwo);
            forestArieseni.Bring(bearthree);

            foreach(Animal a in forestArieseni.animals)
            {
                Console.WriteLine(a.Id);
            }

            Habitat habitatulmeu = new Habitat();
            habitatulmeu.add(forestArieseni.animals);

            Console.WriteLine(forestFood.FoodQuantity(FoodType.OmnivoreFood));
        }
    }
}

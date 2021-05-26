using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1
{
    public enum AnimalDiet
    {
        Herbivore,
        Omnivore
    }

    public class Animal
    {
        public AnimalDiet Diet { get; set; }
        public Animal()
        {

        }

        public void Eat(Food food)
        {
            if (Diet == AnimalDiet.Herbivore)
                food.Feeder(FoodType.Hay);
            if (Diet == AnimalDiet.Omnivore)
                food.Feeder(FoodType.Grain);
        }

    }
}

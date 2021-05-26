using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1
{
    public enum AnimalType
    {
        Herbivore,
        Omnivore
    }

    public class Animal
    {
        public Animal()
        {

        }

        public void Eat(FoodType foodType, Food food)
        {
            if (foodType == FoodType.Hay)
                food.Feeder(FoodType.Hay);
            if (foodType == FoodType.Grain)
                food.Feeder(FoodType.Grain);
        }

    }
}

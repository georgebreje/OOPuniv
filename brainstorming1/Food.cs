using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1
{
    public enum FoodType
    {
        Hay,
        Grain
    }
    public class Food
    {
        private int hayQuantity = 100;
        private int grainQuantity = 100;
        public int HayQ { get { return hayQuantity; } }
        public int GrainQ { get { return grainQuantity; } }


        public Food()
        {

        }

        public void Feeder(FoodType foodType)
        {
            if (foodType == FoodType.Hay)
                hayQuantity -= 50;
            if (foodType == FoodType.Grain)
                grainQuantity -= 50;
        }

        private int FoodQuantity(FoodType foodType)
        {
            if (foodType == FoodType.Hay)
                return hayQuantity;
            if (foodType == FoodType.Grain)
                return grainQuantity;
            return 0;
        }
    }
}

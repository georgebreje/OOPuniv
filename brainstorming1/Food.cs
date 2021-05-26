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
        private int hayQ = 100;
        private int grainQ = 100;
        public int HayQ { get { return hayQ; } }
        public int GrainQ { get { return grainQ; } }


        public Food()
        {

        }

        public void Feeder(FoodType foodType)
        {
            if (foodType == FoodType.Hay)
                hayQ -= 50;
            if (foodType == FoodType.Grain)
                grainQ -= 50;
        }

        private int FoodQuantity(FoodType foodType)
        {
            if (foodType == FoodType.Hay)
                return hayQ;
            if (foodType == FoodType.Grain)
                return grainQ;
            return 0;
        }
    }
}

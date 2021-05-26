using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1
{
    public enum FoodType
    {
        HerbivoreFood ,
        CarnivoreFood,
        OmnivoreFood,
        DetritivoreFood
    }
    public class Food
    {
        private int omnivoreFoodQuantity = 100;
        public Food() { }
        public int FoodQuantity(FoodType foodType)
        {
            if (foodType == FoodType.OmnivoreFood)
                return omnivoreFoodQuantity;
            return 0;
        }
    }
}

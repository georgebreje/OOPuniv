using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using brainstorming1.Exceptions;

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
        public int HayQuantity { get { return hayQuantity; } }
        public int GrainQuantity { get { return grainQuantity; } }
        Dictionary<FoodType, int> foodTypeQuantity = new Dictionary<FoodType, int>();

        public void InitializeStock()
        {
            foodTypeQuantity.Add(FoodType.Hay, HayQuantity);
            foodTypeQuantity.Add(FoodType.Grain, GrainQuantity);
        }

        public Food()
        {

        }

        public bool Feeder(FoodType foodType)
        {
            if (foodType == FoodType.Hay && foodTypeQuantity[FoodType.Hay] != 0)
            {
                foodTypeQuantity[FoodType.Hay] -= 50;
                return true;
            }
            else if (foodType == FoodType.Hay && foodTypeQuantity[FoodType.Hay] == 0)
                throw new NoMoreFoodException("Add Hay to the stock.");

            if (foodType == FoodType.Grain && foodTypeQuantity[FoodType.Grain] != 0)
            {
                foodTypeQuantity[FoodType.Grain] -= 50;
                return true;
            }
            else if (foodType == FoodType.Grain && foodTypeQuantity[FoodType.Grain] == 0)
                throw new NoMoreFoodException("Add Grain to the stock.");
            return false;
        }

        public int FoodQuantity()
        {
            int totalFood = 0;
            foreach (KeyValuePair<FoodType, int> kvp in foodTypeQuantity)
                totalFood += kvp.Value;
            return totalFood;
        }
    }
}
﻿using System;
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
            Animal dog = new Animal();
            Food farmfood = new Food();
            farmfood.InitializeStock();


            cow.Diet = AnimalDiet.Herbivore;
            dog.Diet = AnimalDiet.Omnivore;
            
            cow.Eat(farmfood);
            cow.Eat(farmfood);
            cow.Eat(farmfood);


            dog.Eat(farmfood);




            Console.WriteLine(farmfood.FoodQuantity());  
        }
    }
}

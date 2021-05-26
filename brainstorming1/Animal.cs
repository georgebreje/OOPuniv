using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1
{
    public enum Diet
    {
        Herbivore,
        Carnivore,
        Omnivore,
        Detritivore
    }

    public abstract class Animal
    {
        public abstract string Name { get;  set; }
        public abstract string Description { get; set; }
        public abstract DateTime Birthday { get; set; }
        public abstract int Age { get;  set; }
        public abstract char Gender { get; set; }
        public abstract int Hunger { get;  set; }
        public abstract int Rest { get; set; }
        public abstract Diet GetDiet { get; }
        public abstract string GetAnimalGroup { get; set; }
        public abstract Point Coordinates { get;  set; }
        public abstract int Id { get; set; }


        // constructor
        public Animal() 
        { 

        }
        public abstract void IsAwake();   // se scade din rest pana cand este <= 0

        public abstract void Eat();

        public abstract void Position();

    }
}

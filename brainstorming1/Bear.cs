using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1
{
    class Bear : Animal
    {
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override DateTime Birthday { get; set; }
        public override int Age { get; set; }
        public override char Gender { get; set; }
        public override int Hunger { get; set; }
        public override int Rest { get; set; }
        public override string GetAnimalGroup { get; set; }
        public override Point Coordinates { get; set; }
        public override Diet GetDiet { get { return Diet.Omnivore; } }

        public List<Bear> ListOfBears = new List<Bear>();
        private static int nextId = 0;
        public int Id { get; private set; }
        public Bear()
        {
            Id = nextId;
            nextId++;
        }
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void IsAwake()
        {
            throw new NotImplementedException();
        }

        public override void Position()
        {
            throw new NotImplementedException();
        }
    }
}

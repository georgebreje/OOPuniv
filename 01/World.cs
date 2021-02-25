using System;

namespace _01
{
    class World
    {
        private int id;

        public World(int id)
        {
            this.id = id;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
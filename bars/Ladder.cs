using System;
namespace bars
{
    class Ladder
    {

        private int level;
        public Ladder(int level)
        {
            this.level = level;
            for (int i = 0; i < level; i++)
            {
                Frame fr = new Frame(new Random().Next(2, 5), new Random().Next(2, 5));
            }
        }
    }
}
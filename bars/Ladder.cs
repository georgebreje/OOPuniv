using System;
namespace bars
{
    class Ladder
    {
        private int w = new Random().Next(2, 5);
        private int l = new Random().Next(2, 5);

        private int level;
        public Ladder(int level)
        {
            this.level = level;
            for (int i = 0; i < level; i++)
            {
                Frame fr = new Frame(w,l);
            }
        }
    }
}
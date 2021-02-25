using System;
namespace bars
{
    class VertBar
    {
        private int v1;
        private int v2;

        public VertBar(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            for(int i = 0; i < v1; i++)
            {
                Console.Write("|");
                for(int j = 0; j < v2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
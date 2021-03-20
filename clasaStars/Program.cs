using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasaStars
{
    class Program
    {
        static void Main(string[] args)
        {
            Stars stea = new Stars(5);
            stea.afiseaza();
        }
    }
    class Stars
    {
        private int value;
        public Stars(int value)
        {
            this.value = value;
        }
        ~Stars()
        {
            Console.WriteLine("Destructor called.");
        }
        public void afiseaza()
        {

            for (int i = 1; i <= value; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(0, -1);
            Complex z2 = new Complex("-30-50i");

            Complex sum = z1 + z2;
            Complex mult = z1.Multiply(z2);
            Console.WriteLine(mult);
        }
    }
}

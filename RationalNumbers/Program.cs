using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(75,18);
            Rational r2 = new Rational(5, 5);
            Rational sum = r1.Add(r2);
            Console.WriteLine(sum);
            sum.Simplify();
            Console.WriteLine(sum);
            Console.WriteLine(r1);
            r1.Simplify();
            Console.WriteLine(r1);
        }
    }
}

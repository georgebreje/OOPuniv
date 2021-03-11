using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class CookRobot : Robot
    {
        public override void greet()
        {
            Console.WriteLine("I'm a robot. I cook.");
        }

        public override void skeleton()
        {
            Console.WriteLine("I use most of the kitchen ustensils.");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class CookRobot : Robot
    {
        private int toolCapacity = 2;
        public override void greet()
        {
            Console.WriteLine("I'm a robot. I cook.");
        }

        public override void skeleton()
        {
            Console.WriteLine("I use most of the kitchen tools.");
        }

        public virtual void cook()
        {
            Kitchen myKitchen = new Kitchen();
            myKitchen.cook();
            Console.WriteLine("Chips are served.");
        }
    }
}

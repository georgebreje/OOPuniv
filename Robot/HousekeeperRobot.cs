using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class HousekeeperRobot : Robot
    {
        public HousekeeperRobot()
        {

        }

        public override void greet()
        {
            Console.WriteLine("I'm a robot. I keep the house clean.");
        }

    }
}

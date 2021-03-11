using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Robot
    {
        public virtual void greet()
        {
            Console.WriteLine("I'm a robot.");
        }

        public virtual void skeleton()
        {
            Console.WriteLine("I can't use neither possess any additional objects.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            CookRobot ratatouille = new CookRobot();
            ratatouille.greet();

            Kitchen myKitchen = new Kitchen();
            ratatouille.cook();
            ratatouille.cook();
            ratatouille.cook();
            ratatouille.cook();
            ratatouille.cook();
            ratatouille.cook();
            ratatouille.cook();
            
        }
    }
}

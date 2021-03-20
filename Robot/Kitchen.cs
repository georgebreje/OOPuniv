using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Kitchen : CookRobot
    {
        Pan myPan = new Pan();
        Oil oliveOil = new Oil();
        Knife myKnife = new Knife();
        Potato myPotato = new Potato(5);

        public override void cook()
        {
            cartofiPai();
        } 
        public void cartofiPai()
        {
            myPan.addOil(oliveOil);
            myKnife.useKnife(myPotato);
            if (myPotato.isChoped())
            {
                myPan.addPotato(myPotato, 5);
            }
            Console.WriteLine(oliveOil) ; 
        }
    }
    public class Oil
    {
        private static float liters = 2;
        public Oil()
        {
            liters -= 0.2f;
        }
        public float getQuantity()
        {
            if (liters <= 0)
                throw new Exception("No more oil.");
            return liters;
        }
    }
    public class Pan
    {
        private static float maxOilCapacity = 0.5f;
        public Pan() { }

        public void addOil(Oil oil)
        {
            if (maxOilCapacity < 0.2)
                throw new Exception("Too much oil");
            maxOilCapacity -= 0.2f;

        }
        public void addPotato(Potato potato, int quantityToAdd)
        {
            potato.use(quantityToAdd);
        }
    }
    public class Potato
    {
        private static bool chopped = false;
        private static int totalQuantity;
        public Potato(int quantity)
        {
            totalQuantity = quantity;
        }
        public bool isChoped()
        {
            return !chopped;
        }
        public void use(int neededQuantity)
        {
            if (neededQuantity > totalQuantity)
                throw new Exception("Not enough potatoes");
            totalQuantity -= neededQuantity;
        }
    }
    public class Knife
    {

        public Knife()
        {

        }

        public void useKnife(Potato newPotato)
        {
            newPotato.isChoped();
            Console.WriteLine("chop chop chop");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("george", "email");
            Person pp = new Person("radu", "email");
            Person ppp = new Person("Petrisor", "email");
            Person pppp = new Person("om", "email");

            Activity curs = new Activity("curs", new string[] { "26042021", "1600" }, new string[] { "26042021", "1700" }, p);
            Activity predat = new Activity("Predat An 3", new string[] { "26042021", "1610" }, new string[] { "26042021", "1700" }, pp);
            Activity sport = new Activity("fac sport", new string[] { "26042021", "1910" }, new string[] { "26042021", "2000" }, ppp);
            Activity lucru = new Activity("lucrez", new string[] { "26042021", "1610" }, new string[] { "26042021", "1650" }, pppp);
            //curs.invite(pp);
            //curs.invite(ppp);
            //curs.invite(pppp);

            //foreach (Activity x in ppp.Agenda.Activities)
            //    Console.WriteLine(x.ToString());


            foreach(Activity a in p.Agenda.find("curs"))
                Console.WriteLine(a.ToString());
        }
    }
}

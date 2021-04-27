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
            Activity curs = new Activity("Q&A session", new string[] { "26042021", "1600" }, new string[] { "26042021", "1700" }, p);
            Activity predat = new Activity("Predat An 3", new string[] { "26042021", "1610" }, new string[] { "26042021", "1700" }, pp);
            Activity sport = new Activity("fac sport", new string[] { "26042021", "1910" }, new string[] { "26042021", "2000" }, ppp);

            curs.invite(pp);
            curs.invite(ppp);

            foreach (Activity x in ppp.Agenda.Activities)
                Console.WriteLine(x.ToString());
        }
    }
}

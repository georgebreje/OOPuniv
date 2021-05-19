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

            Activity curs = new Activity("curs", new string[] { "26042021", "1600" }, new string[] { "26042021", "1700" }, p);
            Person coleg = new Person("radu", "email");
            Activity sport = new Activity("sport", new string[] { "26042021", "1610" }, new string[] { "26042021", "1700" }, coleg);

            curs.invite(coleg);



            foreach(Activity a in p.Agenda.Activities)
            {
                Console.WriteLine(a);
            }

            
        }
    }
}

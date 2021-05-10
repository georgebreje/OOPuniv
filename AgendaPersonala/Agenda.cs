using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    class Agenda
    {
        private List<Activity> activityList;

        public Agenda()
        {
            activityList = new List<Activity>();
        }

        public void groupMeet()
        {

        }

        public void raport(string[] begin, string[] end)
        {
            DateTime slimit = parseData(begin);
            DateTime flimit = parseData(end);
            foreach(Activity a in Activities)
            {
                if(a.getStart() > slimit && a.getFinish() < flimit)
                    Console.WriteLine(a.ToString());
            }
        }

        public void delete(Activity toDelete)
        {
            foreach (Activity a in Activities.ToList())
            {
                if (toDelete == a)
                    Activities.Remove(a);
            }
        }
        public List<Activity> find(string toFind)
        {
            List<Activity> found = new List<Activity>();
            foreach (Activity a in this.Activities)
            {
                if (a.getDescription() == toFind)
                    found.Add(a);
            }
            return found;
        }

        public List<Activity> Activities { get => activityList; }
        private DateTime parseData(string[] inputDateHour)
        {
            DateTime outData = new DateTime();
            string[] formats = { "ddMMyyyy", "HHmm" };
            foreach (var dataToParse in inputDateHour)
            {
                if (!DateTime.TryParseExact(dataToParse, formats, null,
                System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                               System.Globalization.DateTimeStyles.AdjustToUniversal,
                               out outData))
                    throw new ArgumentException("Enter data in this format: ddMMyyyy HHmmss");
            }
            return outData;
        }

    }
}

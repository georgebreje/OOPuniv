using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    class Agenda
    {
        private Person holder;
        private List<Activity> activityList;

        public Agenda(Person holder)
        {
            this.holder = holder;
        }

        private DateTime parseData(string[] inputDateHour)
        {
            DateTime outData = new DateTime();
            string[] formats = { "ddMMyyyy", "HHmm" };
            bool ok = false;
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

        public void add(string description, string[] inputStart, string[] inputFinish)
        {
            DateTime start = parseData(inputStart);
            DateTime finish = parseData(inputFinish);
            Activity toAdd = new Activity(description, start, finish);
            foreach (Activity a in activityList)
                if (DateTime.Compare(toAdd.getStart(), a.getStart()) == 0
                    || (DateTime.Compare(toAdd.getStart(), a.getStart()) > 0 && DateTime.Compare(toAdd.getStart(), a.getFinish()) < 0)
                    || (DateTime.Compare(toAdd.getStart(), a.getFinish()) < 0 && DateTime.Compare(toAdd.getFinish(), a.getFinish()) < 0))
                    throw new Exception("You already have an activity at that time.");
            activityList.Add(toAdd);
        }


    }
}

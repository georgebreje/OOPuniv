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

        public void add(string description, DateTime start, DateTime finish)
        {
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

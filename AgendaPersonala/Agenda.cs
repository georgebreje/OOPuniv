using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    class Agenda : Person
    {
        private Person holder;
        private List<Activity> activityList;

        public Agenda()
        {

        }

        public Agenda(Person holder)
        {
            this.holder = holder;
        }

        public void add(Activity toAdd)
        {
            foreach (Activity a in activityList)
                if (DateTime.Compare(toAdd.getStart(), a.getStart()) == 0
                    || (DateTime.Compare(toAdd.getStart(), a.getStart()) > 0 && DateTime.Compare(toAdd.getStart(), a.getFinish()) < 0)
                    || (DateTime.Compare(toAdd.getStart(), a.getFinish()) < 0 && DateTime.Compare(toAdd.getFinish(), a.getFinish()) < 0))
                    throw new Exception("You already have an activity at that time.");
            activityList.Add(toAdd);
        }


    }
}

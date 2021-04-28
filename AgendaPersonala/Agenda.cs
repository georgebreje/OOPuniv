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

        private void orderActivities()
        {

        }

        public void delete(Person p, Activity toDelete)
        {
            foreach (Activity a in p.Agenda.Activities.ToList())
            {
                if (toDelete == a)
                    p.Agenda.Activities.Remove(a);
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


    }
}

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


        public List<Activity> Activities { get => activityList; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    class Activity
    {
        private string description;
        private DateTime start;
        private DateTime finish;

        public Activity()
        {

        }

        public Activity(string description, DateTime start, DateTime finish)
        {
            this.description = description;
            this.start = start;
            this.finish = finish;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setStart(DateTime start)
        {
            this.start = start;
        }
        public void setFinish(DateTime finish)
        {
            this.finish = finish;
        }

        public string getDescription()
        {
            return description;
        }

        public DateTime getStart()
        {
            return start;
        }

        public DateTime getFinish()
        {
            return finish;
        }

        public override string ToString()
        {
            return description + " de la " + start + " pana la " + finish;
        }
    }
}

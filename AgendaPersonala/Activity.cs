using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    class Activity : Agenda
    {
        private string description;
        private DateTime start;
        private DateTime finish;

        public Activity()
        {

        }

        public Activity(string description, string[] start, string[] finish)
        {
            this.description = description;
            this.start = parseData(start);
            this.finish = parseData(finish);
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

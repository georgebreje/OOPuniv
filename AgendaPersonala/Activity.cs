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
        private string[] startInput;
        private string[] finishInput;
        private List<Person> participants;

        public Activity()
        {
            participants = new List<Person>();
        }

        public Activity(string description, string[] start, string[] finish, Person participant)
        {
            participants = new List<Person>();
            participant.Agenda.Activities.Add(this);  // aici se adauga activitatea in agenda participantului / hostului
            participants.Add(participant);
            this.startInput = start;
            this.finishInput = finish;
            this.description = description;
            this.start = parseData(start);
            this.finish = parseData(finish);
        }

        

        public void invite(Person toInvite)
        {
            bool ok = true;
            foreach(Activity a in toInvite.Agenda.Activities)
            {
                if (a.getStart() >= this.getStart() && a.getFinish() <= this.getFinish())
                {
                    ok = false;
                    break;
                }
            }
            if (ok == true)
            {
                toInvite.Agenda.Activities.Add(this);
                this.Participants.Add(toInvite);
            }
            else
                Console.WriteLine($"{toInvite.Name} has an activity at that time.");
        }

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

        public List<Person> Participants { get => participants; }

        public string getDescription()
        {
            return description;
        }

        public string[] getStartInput() { return startInput; }

        public string[] getFinishInput() { return finishInput; }

        public DateTime getStart() { return start; }

        public DateTime getFinish()
        {
            return finish;
        }

        public static bool operator ==(Activity a, Activity b)
        {
            if (a.ToString() == b.ToString())
                return true;
            return false;
        }
        public static bool operator !=(Activity a, Activity b)
        {
            if (a == b)
                return false;
            return true;
        }
        public override string ToString()
        {
            return description + " de la " + start + " pana la " + finish;
        }
    }
}
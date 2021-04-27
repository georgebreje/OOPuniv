using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    class Person
    {
        private string name;
        private string email;
        private Agenda personAgenda;

        public Person()
        {
            this.personAgenda = new Agenda();
        }

        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
            this.personAgenda = new Agenda();
        }

        

        public Agenda Agenda { get => personAgenda; }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
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
    }
}

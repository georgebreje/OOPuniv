using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortByName
{
    class ProcessingData
    {
        private string fileName;
        public List<Person> personList = new List<Person>();
        public ProcessingData(string fileName)
        {
            this.fileName = fileName;
        }

        public void ceva()
        {
            TextReader load = new StreamReader(fileName);
            string buffer;
            while ((buffer = load.ReadLine()) != null)
            {
                Person p = new Person(buffer.Split(' '));
                p.CheckName(p.Nume);
                p.CheckName(p.Prenume1);
                try
                {
                    if (buffer.Split(' ').Length > 1)
                        p.CheckName(p.Prenume2);
                }
                catch (Exception e) { }
                personList.Add(p);
            }
        }
    }
}
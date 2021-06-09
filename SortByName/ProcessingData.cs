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

        public void RetrieveData()
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

        public void SortStudents()
        {
            for (int i = 0; i < personList.Count - 1; i++)
            {
                char[] numeI = personList[i].Nume.ToCharArray();
                char[] numeJ = personList[i + 1].Nume.ToCharArray();

                int minLengthNume = numeI.Length < numeJ.Length ? numeI.Length : numeJ.Length;
                bool okNume = true;

                for (int q = 0; q < minLengthNume && okNume; q++)
                {
                    if (numeI[q] < numeJ[q])
                    {
                        Person aux = personList[i + 1];
                        personList[i + 1] = personList[i];
                        personList[i] = aux;
                        okNume = false;
                    }
                }

                char[] firstNameI = personList[i].Prenume1.ToCharArray();
                char[] firstNameJ = personList[i + 1].Prenume1.ToCharArray();

                int minLengthFirstName = firstNameI.Length < firstNameJ.Length ? firstNameI.Length : firstNameI.Length;
                bool okFirstName = true;
                for (int q = 0; q < minLengthFirstName && okFirstName; q++)
                {
                    if (firstNameI[q] < firstNameJ[q])
                    {
                        Person aux = personList[i + 1];
                        personList[i + 1] = personList[i];
                        personList[i] = aux;
                        okFirstName = false;
                    }
                }
                try
                {
                    char[] firstName1I = personList[i].Prenume2.ToCharArray();
                    char[] firstName1J = personList[i + 1].Prenume2.ToCharArray();

                    int minLengthFirstName1 = firstName1I.Length < firstName1J.Length ? firstName1I.Length : firstName1I.Length;
                    bool okFirstName1 = true;
                    for (int q = 0; q < minLengthFirstName1 && okFirstName1; q++)
                    {
                        if (firstName1I[q] < firstName1J[q])
                        {
                            Person aux = personList[i + 1];
                            personList[i + 1] = personList[i];
                            personList[i] = aux;
                            okFirstName1 = false;
                        }
                    }
                } catch (Exception e) { }
            }
        }
    }
}
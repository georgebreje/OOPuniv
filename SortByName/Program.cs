using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByName
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = 'Ș'; // int = 536
            char c2 = 'Ț'; // int = 538
            ProcessingData run = new ProcessingData(@"../../TextFile1.txt");
            run.RetrieveData();
            run.SortStudents();
            foreach (Person p in run.personList)
                Console.WriteLine(p.ToString()) ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TemaElev
{
    class Program
    {
        static void Main(string[] args)
        {
            Elev infoAnI = new Elev(@"../../MediiElevi.txt");
            infoAnI.sortStudents();
            infoAnI.sortedListOutput();
            //List<string> currentStudent = new List<string>();
            //List<string[]> studentInfo;
            //TextReader loadFile = new StreamReader(@"../../MediiElevi.txt");
            //string buffer/*, eachLine*/;
            //List<string> studentData = new List<string>();
            //studentInfo = new List<string[]>();

            //while ((buffer = loadFile.ReadLine()) != null)
            //{
            //    string[] arr = buffer.Split(' ');
            //    studentInfo.Add(arr);
            //}

            //float[] saveAvg = new float[studentInfo.Count];
            //for (int i = 0; i < studentInfo.Count; i++)
            //{
            //    // media studentului
            //    int sum = 0;
            //    for (int j = 3; j < studentInfo[i].Length; j++)
            //    {
            //        sum += int.Parse(studentInfo[i][j]);
            //    }
            //    saveAvg[i] = (float)sum / int.Parse(studentInfo[i][2]);
            //}

            //// sortarea in functie de medie
            //for (int i = 0; i < studentInfo.Count - 1; i++)
            //{
            //        if (saveAvg[i] < saveAvg[i + 1])
            //        {
            //            string[] aux = studentInfo[i];
            //            studentInfo[i] = studentInfo[i + 1];
            //            studentInfo[i + 1] = aux;
            //        }
            //        else if (saveAvg[i] == saveAvg[i + 1])
            //        {
                        
            //            // trebuie sa compar fiecare litera cu fiecare litera din cele 2 nume

            //            char[] lastNameI = studentInfo[i][0].ToCharArray();
            //            char[] lastNameJ = studentInfo[i + 1][0].ToCharArray();


            //            int minLengthLastName = lastNameI.Length < lastNameJ.Length ? lastNameI.Length : lastNameJ.Length;  // alegem numele cu lungimea mai mica ca sa evitam indexoutofrange
            //            bool okLastName = true;
            //            bool ok2 = false;
            //            for (int q = 0; q < minLengthLastName && okLastName; q++)
            //            {
            //                if (lastNameI[q] < lastNameJ[q])
            //                {
            //                    Console.WriteLine("Crapa litera " + lastNameI[q]);
            //                    string[] aux = studentInfo[i + 1];
            //                    studentInfo[i + 1] = studentInfo[i];
            //                    studentInfo[i] = aux;
            //                    okLastName = false;
            //                }
            //            }

                        
            //                char[] firstNameI = studentInfo[i][0].ToCharArray();
            //                char[] firstNameJ = studentInfo[i + 1][1].ToCharArray();

            //                int minLengthFirstName = firstNameI.Length < firstNameJ.Length ? firstNameI.Length : firstNameI.Length;
            //                bool okFirstName = true;
            //                for (int q = 0; q < minLengthFirstName && okFirstName; q++)
            //                {
            //                    if (firstNameI[q] < firstNameJ[q])
            //                    {
            //                        string[] aux = studentInfo[i + 1];
            //                        studentInfo[i + 1] = studentInfo[i];
            //                        studentInfo[i] = aux;
            //                        okFirstName = false;
            //                    }
            //                }
            //    }
            //}
            //foreach (string[] s in studentInfo)
            //    foreach (string b in s)
            //        Console.WriteLine(b);
        
            //// afisare in alt fisier

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByName
{
    class Person
    {
        private string nume;
        private string prenume1;
        private string prenume2;
        public string Nume { get { return nume; } }
        public string Prenume1 { get { return prenume1; } }
        public string Prenume2 { get { return prenume2; } }

        public Person(string[] name)
        {
            this.nume = name[0];
            this.prenume1 = name[1];
            try
            {
                if (name.Length > 1)
                    this.prenume2 = name[2];
            } catch (Exception e) { }
        }

        public override string ToString()
        {
            return Nume + " " + Prenume1 + " " + Prenume2;
        }

        public void CheckName(string nameToCheck)
        {
            int count = 0;
            foreach (char c in nameToCheck)
                if (c < 61)
                    count++;

            if (count > 1)
                RewriteName(nameToCheck);

            if (UpperCaseMissing(nameToCheck))
                NameWithCapital(nameToCheck);
        }

        public void RewriteName(string nameToRewrite)
        {
            char[] chArr = nameToRewrite.ToCharArray();

            for (int i = 1; i < chArr.Length; i++)
                Char.ToLower(chArr[i]);

            nameToRewrite = new string(chArr);
        }

        public bool UpperCaseMissing(string nameToCheck)
        {
            char[] chArr = nameToCheck.ToCharArray();
            if (chArr[0] >= 'a')
                return true;
            return false;
        }

        public void NameWithCapital(string nameToRewrite)
        {
            char[] chArr = nameToRewrite.ToCharArray();
            Char.ToUpper(chArr[0]);
            nameToRewrite = new string(chArr);

        }
    }
}
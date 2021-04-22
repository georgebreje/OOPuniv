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

        public Person()
        {

        }

        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public bool isBusy()
        {
            
            return true;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }

    }
}

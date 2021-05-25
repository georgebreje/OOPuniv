using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        // fiecare angajat are in ingrijire anumite animale
        // un angajat poate sa se ocupe de animale sau de partea administrativa

        public int Id { get; private set; }

        // constructor
    }
}

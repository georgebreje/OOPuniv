using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1
{
    class Forest : Habitat
    {
        public override string Name { get ; set ; }
        public override string Description { get ; set ; }

        public List<Animal> listofanimals = new List<Animal>();
    }
}

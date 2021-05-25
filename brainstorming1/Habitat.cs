using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1
{
    public abstract class Habitat
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public int Size { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1.Exceptions
{
    public class NoMoreFoodException : Exception
    {
        public NoMoreFoodException(string message) : base(message)
        {

        }
    }
}

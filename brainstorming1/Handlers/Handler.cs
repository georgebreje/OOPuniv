using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainstorming1
{
    public abstract class Handler<T> : IHandler<T> 
    {
        private IHandler<T> Next { get; set; }
        public virtual void Handle(T request)
        {
            Next?.Handle(request);
        }

        public virtual IHandler<T> SetNext(IHandler<T> handler)
        {
            Next = Next;
            return Next;
        }
    }
    public interface IHandler<T> 
    {
        IHandler<T> SetNext(IHandler<T> handler);
        void Handle(T request);
    }

    public class CowFoodHandler : Handler<Food>
    {
        public override void Handle(Food food)
        {

        }
    }


}

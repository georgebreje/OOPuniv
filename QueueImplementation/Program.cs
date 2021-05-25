﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>(2);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            foreach (var item in q)
                Console.WriteLine(item);
        }
    }
}

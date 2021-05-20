using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation.Tests
{
    [TestClass()]
    public class CustomQueueArrTests
    {
        [TestMethod()]
        public void EnqueueTest()
        {
            // arrange
            Queue<int> testq = new Queue<int>(3);
            testq.Enqueue(1);
            testq.Enqueue(2);
            testq.Enqueue(3);

            // act
            int[] result = new int[3];

            int i = 0;
            foreach (int value in testq)
            {
                result[i] = value;
                i++;
            }

            int[] expected = { 1, 2, 3 };

            // assert
            Assert.AreEqual(result, expected);
        }
    }
}
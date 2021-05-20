using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public interface IQueue<T>
    {
        T Peek();
        void Enqueue(T val);
        T Dequeue();



    }

    public class CustomQueueArr<T> : IQueue<T>, IEnumerable<T>
    {
        private int size;
        private int head, tail;
        private T[] data;
        public int Count { get; private set; } = 0;
        public CustomQueueArr(int size)
        {
            this.size = size;
            data = new T[size];
        }

        public void Enqueue(T value)
        {
            if ((head == 0 && tail == size - 1) || (tail == head - 1))
            {
                T[] tempArr = new T[Count + 1];

                if (head != -1)
                {
                    int j = 0;
                    if (tail >= head)
                    {
                        for (int i = head; i <= tail; i++)
                        {
                            tempArr[j] = data[i];
                            j++;
                        }
                    }
                    else
                    {
                        for (int i = head; i < size; i++)
                        {
                            tempArr[j] = data[i];
                            j++;
                        }
                    }
                }

                data = tempArr;
                head = 0;
                tail = Count;
                size++;
            }
            else
            {
                if (head == -1 && tail == -1)
                {
                    head++;
                    tail++;
                }
                else if (tail == size - 1)
                    tail = 0;
                else
                    tail++;

                data[tail] = value;
            }
            Count++;
        }

        public T Dequeue()
        {
            if (head == -1)
                throw new Exception("Queue is empty");
            T front = data[head];

            if (head == tail)
            {
                head = -1;
                tail = -1;
            }
            else if (head == size - 1)
                head = 0;
            else
                head++;
            Count--;
            return front;
        }

        public T Peek()
        {
            if (head < 0)
                throw new Exception("Queue is empty");
            return data[head];
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (head != -1)
            {
                if (tail >= head)
                {
                    for (int i = head; i <= tail; i++)
                        yield return data[i];
                }
            }
            else
            {
                for (int i = head; i < size; i++)
                    yield return data[i];

                for (int i = 0; i < tail; i++)
                    yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

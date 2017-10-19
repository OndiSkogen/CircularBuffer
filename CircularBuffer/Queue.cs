using System;
using System.Collections.Generic;
using System.Text;

namespace CircularBuffer
{
    class Queue
    {
        private int[] buf;

        private int head;
        private int tail;

        public Queue(int n)
        {
            buf = new int[++n];
            head = 0;
            tail = 0;
        }

        public void Enqueue(int put)
        {
                buf[head] = put;
                head = (head + 1) % buf.Length;
        }

        public void Dequeue()
        {
            if (tail == head)
            {
                Console.WriteLine("Buffer is empty.");
            }
            else
            {
                Console.WriteLine(buf[tail] + " was removed.");
                buf[tail] = 0;
                tail = (tail + 1) % buf.Length;
            }            
        }

        public bool Full()
        {
            if (tail == (head + 1) % (buf.Length))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Empty()
        {
            if (head == 0 && tail == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

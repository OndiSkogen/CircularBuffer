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
        private int count;

        public Queue(int n)
        {
            buf = new int[n];
            head = 0;
            tail = 0;
            count = 0;
        }

        public void Enqueue(int put)
        {
            count++;
            buf[head] = put;
            head = (head + 1) % buf.Length;
        }

        public void Dequeue()
        {
            Console.WriteLine(buf[tail] + " was removed.");
            count--;
            buf[tail] = 0;
            tail = (tail + 1) % buf.Length;    
        }

        public bool Full()
        {
            if (count > 0 && head == tail)
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
            if (count == 0)
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

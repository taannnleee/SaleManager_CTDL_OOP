using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.DataStructure.Base
{
    public class Queue<T>
    {
        private LinkedList<T> queuelist;

        public LinkedList<T> QueueList { get => queuelist; set => queuelist = value; }

        public Queue() 
        {
            this.queuelist = null;
        }

        public void push(T element)
        {
            queuelist.AddLast(element);
            queuelist.Size++;
        }

        public void pop()
        {
            queuelist.RemoveHead();
            queuelist.Size--;
        }

        public T peek()
        {
            return queuelist.peekHead();
        }
    }
}

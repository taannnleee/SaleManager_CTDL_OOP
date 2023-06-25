using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.DataStructure.Base
{
    public class Stack<T>
    {
        private LinkedList<T> list;

        public LinkedList<T> List { get => list; set => list = value; }

        public Stack() 
        {
            this.list = null;
        }  

        public void push(T element)
        {
            list.AddLast(element);
            list.Size++;
        }

        public void pop() 
        {
            list.RemoveTail();
            list.Size--;
        }

        public T peek()
        {
            return list.peekLast();
        }
    }
}

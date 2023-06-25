using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.DataStructure.Base
{
    public class Node<T>
    {
        public T item;
        public Node<T>? next;
        public Node<T>? previous;

        public Node(T value)
        {
            this.item = value;
            next = null; 
            previous = null;
        }
    }



}

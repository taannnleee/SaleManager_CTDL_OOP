using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.DataStructure.Base
{
    public class Node<T>
    {
        private T item;
        private Node<T>? next;
        private Node<T>? previous;

        public Node(T value)
        {
            this.item = value;
            next = null; 
            previous = null;
        }
    }
}

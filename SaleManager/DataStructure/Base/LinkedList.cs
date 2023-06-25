
﻿using System;
﻿using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.DataStructure.Base
{
    public class LinkedList<T>
    {

        protected Node<T>? nFirstItem;
        protected Node<T>? nLastItem;
        protected int iSize;

        public LinkedList()
        {
            nFirstItem = null;
            nLastItem = null;
            this.iSize = 0;
        }

        public Node<T>? FirstItem
        {
            get { return nFirstItem; }
            set { nFirstItem = value; }
        }

        public Node<T>? LastItem
        {
            get { return nLastItem; }
            set { nLastItem = value; }
        }

        public int Size
        {
            get { return iSize; }
            set { iSize = value; }
        }

        // methods

        public void clear()
        {
            LinkedList<int> a = new LinkedList<int> {  };            
            Node<T>? currentNode = nFirstItem;
            while(currentNode != null)
            {
                Node<T>? nextNode = currentNode.next;
                currentNode.next = null;
                currentNode.previous = null;
                currentNode.item = default(T);
                currentNode = nextNode;
            }
            nFirstItem = nLastItem = null;
            iSize = 0;
        }

        public void AddFirst(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (IsEmpty())
                nFirstItem = nLastItem = newNode;
            else
            {
                newNode.next = nFirstItem;
                nFirstItem.previous = newNode;
                nFirstItem = newNode;
            }
            iSize++;
        }

        public void AddLast(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if(IsEmpty())
            {
                nFirstItem = nLastItem = newNode;
            }
            else
            {
                newNode.previous = nLastItem;
                nLastItem.next = newNode;
                nLastItem = newNode;
            }
            iSize++;
        }

        public T GetItem(int index)
        {
            Node<T>? head = nFirstItem;
            for(int i = 0;i<index; i++)
            {
                head = head.next;
            }
            return head.item;
        }

        public T peekFirst()
        {
            if(IsEmpty())
            {
                throw new Exception("Empty linked list");
            }
            return nFirstItem.item;
        }

        public T peekLast()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty linked list");
            }
            return nLastItem.item;
        }

        public T peekHead()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty linked list");
            }
            return nFirstItem.item;
        }

        public bool IsEmpty()
        {
            return this.nFirstItem == null;
        }

        public T RemoveHead()
        {
            if (IsEmpty()) throw new Exception("Empty linked list");
            T data = nFirstItem.item;
            nFirstItem = nFirstItem.next;
            Size--;
            if (IsEmpty())
                nLastItem = null;
            else
                nFirstItem.previous=null;
            return data;
        }

        public T RemoveTail()
        {
            if(IsEmpty()) throw new Exception("Empty linked list");
            T data = nLastItem.item;
            nLastItem = nLastItem.previous;
            Size--;
            if (IsEmpty())
                nFirstItem = null;
            else
                nLastItem.next = null;
            return data;
        }

        public void RemoveCurrentNode(Node<T>? currentNode)
        {
            if (IsEmpty())
            {
                return;
            }

            if (currentNode == nFirstItem)
            {
                nFirstItem = currentNode.next;

                if (nFirstItem != null)
                {
                    nFirstItem.previous = null;
                }
                else
                {
                    // currentNode was the only element in the list
                    nLastItem = null;
                }
            }
            else if (currentNode == nLastItem)
            {
                nLastItem = currentNode.previous;
                nLastItem.next = null;
            }
            else
            {
                currentNode.previous.next = currentNode.next;
                currentNode.next.previous = currentNode.previous;
            }

            iSize--;
        }

        public Node<T>? GetNode(T item)
        {
            Node<T>? head  = nFirstItem;
            while(head != null)
            {
                if(item.Equals(head.item))
                {
                    return head;
                }
                head = head.next;
            }
            return null;
        }

        public Node<T> RemoveAt(int index) 
        {
            Node<T> removeAt = GetNodeByIndex(index);
            RemoveCurrentNode(removeAt);
            return removeAt;
        }

        public Node<T>? GetNodeByIndex(int index)
        {
            if (index < 0 || index >= Size) throw new Exception("index value out of bounds");
            Node<T>? currentNode;
            if (index < iSize/2)
            {
                int i = 0;
                currentNode = nFirstItem;
                while (i!= index)
                {
                    currentNode = currentNode.next;
                    i++;
                }
            }
            else
            {
                int i = iSize;
                currentNode = nLastItem;
                while (i != index)
                {
                    currentNode = currentNode.previous;
                    i--;
                }
            }
            return currentNode;
        }

        public bool Contains(Node<T>? currentNode)
        {
            Node<T> getnode = GetNode(currentNode.item);
            if (getnode != null)
            {
                return true;
            }
            return false;
        }
    }
}

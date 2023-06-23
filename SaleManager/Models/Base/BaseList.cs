using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Models;

namespace SaleManager.Models.Base
{
    public abstract class BaseList<T>
    {
        // Fields
        protected T[] list_;
        protected int iSize;
        protected int capacity;
        // Constuctor
        public BaseList(int capacity)
        {

            this.List = new T[capacity];
            this.Capacity = capacity;
            this.Size = 0;
        }
        //Proerties
        public int Size
        {
            get { return iSize; }
            set { iSize = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public T[] List
        {
            get { return list_; }
            set { list_ = value; }
        }

        public T this[int i]
        {
            get
            {
                return list_[i];
            }
            set
            {
                list_[i] = value;
            }
        }

        // Methods
        public virtual bool IsEmpty()
        {
            return iSize == 0;
        }

        public bool isFull()
        {
            return iSize >= capacity;
        }
        public bool IsValidIndex(int index)
        {
            return index >= 0 && index < iSize;
        }
        public abstract void AddItem(int index, T item);
        public abstract T Get(int index);
        public abstract void AddLast(T item);
        public abstract void AddRange(BaseList<T> sourceList);
        public abstract void RemoveItem(int index);
        public abstract void Print();
        public abstract T SearchItem(T item);
        public abstract int IndexOf(T item);
    }

}

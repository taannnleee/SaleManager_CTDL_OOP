﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.DataStructure.Base
{
    public class LinkedList<T>
    {
        private int size;
        private Node<T>? firtItem;
        private Node<T>? lastItem;
    }
}

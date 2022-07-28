using System;
using System.Collections.Generic;


    class LList
    {
        public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
        {
            LinkedListNode<int> current = myLList.First;
            while (current != null)
            {
                if (current.Value > n)
                {
                    break;
                }
                current = current.Next;
            }
            LinkedListNode<int> newNode = myLList.AddBefore(current, n);
            return newNode;
        }
    }


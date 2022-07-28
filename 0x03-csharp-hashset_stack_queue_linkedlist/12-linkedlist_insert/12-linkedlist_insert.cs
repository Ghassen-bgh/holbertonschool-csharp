using System;
using System.Collections.Generic;


    class LList
    {
        public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
        {
            if(myLList.Count == 0)
            {
                myLList.AddFirst(n);
                return myLList.First;
            }
            LinkedListNode<int> current = myLList.First;
            while(current.Next != null)
            {
                if(current.Value < n && current.Next.Value > n)
                {
                    myLList.AddAfter(current, n);
                    return current.Next;
                }
                current = current.Next;
            }
            myLList.AddAfter(current, n);
            return current.Next;
        }
    }


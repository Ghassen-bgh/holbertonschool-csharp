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
            while(current != null)
            {
                if(n <= current.Value)
                {
                    myLList.AddBefore(current, n);
                    return current.Previous;
                }
                if(current.Next != null)
                    current = current.Next;
                else
                    break;

            }
            myLList.AddAfter(current, n);
            return current;
    }
    }


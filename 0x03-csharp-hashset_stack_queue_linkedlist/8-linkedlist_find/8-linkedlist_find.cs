using System;
using System.Collections.Generic;


    class LList
    {
        public static int FindNode(LinkedList<int> myLList, int value)
        {
            LinkedListNode<int> current = myLList.First;
            int pos = 0;
            while (current != null)
            {
                if (current.Value == value)
                    return pos;
                current = current.Next;
                pos++;
            }
            return -1;
        }
    }


﻿using System;
using System.Collections.Generic;


    class LList
    {
        public static int Pop(LinkedList<int> myLList)
        {
            int popped = myLList.First.Value;
            if (myLList.Count == 0)
            {
                return 0;
            }
            else
            {
                myLList.RemoveFirst();
            }
            return popped;
        }
    }

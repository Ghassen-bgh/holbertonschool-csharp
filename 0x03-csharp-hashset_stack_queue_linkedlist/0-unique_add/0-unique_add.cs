using System;
using System.Collections.Generic;


    class List
    {
        public static int Sum(List<int> myList)
        {
            HashSet<int> mySet = new HashSet<int>();
            foreach(int item in myList)
            {
                mySet.Add(item);
            }
            int sum = 0;
            foreach(int item in mySet)
            {
                sum += item;
            }
            return sum;
        }
    }

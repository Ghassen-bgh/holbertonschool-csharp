﻿using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> CommonElements(List<int> list1, List<int> list2)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            foreach (int item in list1)
            {
                set1.Add(item);
            }
            foreach (int item in list2)
            {
                set2.Add(item);
            }
            List<int> common = new List<int>();
            foreach (int item in set1)
            {
                if (set2.Contains(item))
                {
                    common.Add(item);
                }
            }
            return common;
        }
    }


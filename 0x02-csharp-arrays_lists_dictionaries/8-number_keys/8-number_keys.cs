﻿using System;
using System.Collections.Generic;


    class Dictionary
    {
        public static int NumberOfKeys(Dictionary<string, string> myDict)
        {
            int i = 0;
            foreach (KeyValuePair<string, string> kvp in myDict)
            {
                i++;
            }
            return i;

        }
    }

using System;
using System.Collections.Generic;


    class Dictionary
    {
        public static void PrintSorted(Dictionary<string, string> myDict)
        {
            List<string> keys = new List<string>();
            foreach (KeyValuePair<string, string> entry in myDict)
            {
                keys.Add(entry.Key);
            }
            keys.Sort();
            foreach (string key in keys)
            {
                Console.WriteLine("{0}: {1}", key, myDict[key]);
            }
        }
    }

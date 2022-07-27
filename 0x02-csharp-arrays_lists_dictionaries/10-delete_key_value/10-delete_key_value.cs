using System;
using System.Collections.Generic;


    class Dictionary
    {
        public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
        {
            Dictionary<string, string> newDict = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> kvp in myDict)
            {
                if (kvp.Key != key)
                {
                    newDict.Add(kvp.Key, kvp.Value);
                }
            }
            return newDict;
        }
    }

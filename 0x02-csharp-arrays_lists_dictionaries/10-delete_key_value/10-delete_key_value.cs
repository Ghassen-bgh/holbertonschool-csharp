using System;
using System.Collections.Generic;


    class Dictionary
    {
        public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
        {
            Dictionary<string, string> newDict = new Dictionary<string, string>();
            if (myDict.ContainsKey(key))
            {
                myDict.Remove(key);
            }
            return myDict;
        }
    }

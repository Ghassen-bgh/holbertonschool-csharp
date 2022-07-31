using System;
using System.Collections.Generic;


    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
            string best = "None";
            int bestScore = 0;
            foreach (KeyValuePair<string, int> entry in myList)
            {
                if (entry.Value > bestScore)
                {
                    best = entry.Key;
                    bestScore = entry.Value;
                }
            }
            return best;    
        }
    }


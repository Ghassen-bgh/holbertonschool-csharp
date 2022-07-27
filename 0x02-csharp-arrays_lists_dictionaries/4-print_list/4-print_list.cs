using System;
using System.Collections.Generic;


    class List
    {
        public static List<int> CreatePrint(int size)
        {
            List<int> newList = new List<int>();
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            if (size > 0)
            {
                int i = 0;
                for(; i < size - 1; i++)
                {
                    newList.Add(i);
                    System.Console.Write("{0} ",i);
                }

                newList.Add(i);
                System.Console.WriteLine("{0}",i);
            }
            else{
                Console.WriteLine();
            }
            return  newList;
        }
    }

using System;

    class Array
    {
        public static int[] CreatePrint(int size)
        {
            int[] newArray = new int[size];
            if (size > 0)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = i;
                    if (i < size -1)
                    {
                        Console.Write(newArray[i] + " ");
                    }
                    else
                    {
                        Console.WriteLine(newArray[i]);
                    }
                }
            }
            else if( size == 0)
            {
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            return newArray;
        }
    }

using System;


    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[5, 5];
            for( int i = 0; i < 5; i++)
            {
                for( int j = 0; j < 5; j++)
                {
                    if (j == 4)
                    {
                        Console.Write("{0}", myArray[i, j]);
                    }
                    else if (i == 2 && j == 2)
                    {
                        myArray[i, j] = 1;
                        Console.Write("{0} ", myArray[i, j]);
                    }
                    else
                    {
                        Console.Write("{0} ", myArray[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }

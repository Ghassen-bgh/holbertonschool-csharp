using System;

    class Line
    {
        public static void PrintDiagonal(int length)
        {
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < i; j++)
                    
                        Console.Write(" ");
                        Console.Write("\\");
                        if ( i == length - 1)
                        continue;
                
                    Console.WriteLine();
                   
                }
            }

            Console.WriteLine();
        }
    }

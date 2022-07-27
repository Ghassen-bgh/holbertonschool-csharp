using System;


    class Array
    {
        public static void Reverse(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                    Console.Write(array[i] + " ");
                else
                    Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }


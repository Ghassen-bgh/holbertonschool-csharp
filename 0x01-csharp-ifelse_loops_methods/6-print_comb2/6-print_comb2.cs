using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            for (a = 0; a < 9; a++)
            {
                for (b = 0; b <= 9; b++)
                {
                    if (a < b)
                    {
                        if (a < 8 || b < 9)
                        {
                            Console.Write($"{a}{b}, ");
                        }
                        else
                        {
                            Console.Write($"{a}{b}");
                        }
                    }
                }
            }
        }
    }
}

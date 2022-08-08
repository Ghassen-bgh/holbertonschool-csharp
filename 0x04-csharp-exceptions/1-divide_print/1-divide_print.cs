﻿using System;


    class Int
    {
        public static void divide(int a, int b)
        {
            var result = 0;
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, result);
            }
        }   
    }


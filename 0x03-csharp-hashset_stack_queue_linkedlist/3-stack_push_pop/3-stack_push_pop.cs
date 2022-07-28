using System;
using System.Collections.Generic;


    class MyStack
    {
        public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
        {
            Console.WriteLine($"Number of items: {aStack.Count}");
            if (aStack.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return aStack;
            }
            else
            {
                Console.WriteLine($"Top item: {aStack.Peek()}");
                if (aStack.Contains(search))
                {
                   Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");

                }
                else
                {
                    Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");
                    return aStack;
                }
                    while (aStack.Contains(search))
                   {
                        aStack.Pop();
                   }
                aStack.Push(newItem);
                return aStack;
            }
        }
    }

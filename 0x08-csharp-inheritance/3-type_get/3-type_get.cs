using System;
using System.Collections.Generic;
using System.Reflection;

    class Obj
    {
        public static void Print(object myObj)
        {
            string string_type = myObj.GetType().Name;
            Type type = myObj.GetType();
            Console.WriteLine("{0} Properties:", string_type);
            foreach (var property in type.GetProperties())
                Console.WriteLine(property.Name);
            Console.WriteLine("{0} Methods:", string_type);
            foreach (var method in type.GetMethods())
                Console.WriteLine(method.Name);
        }
    }


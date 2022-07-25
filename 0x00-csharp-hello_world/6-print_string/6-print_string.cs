using System;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        string a = new StringBuilder(str.Length * 3).Insert(0, str, 3).ToString();
        string b = str.Substring(0, 9);
		Console.WriteLine("{0}\n{1}", a, b);        
    }
}
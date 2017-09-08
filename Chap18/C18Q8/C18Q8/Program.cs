using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Assembly.GetAssembly(typeof(型名)));
    }
}

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        object[] a = { 123, "Hello!", 456, 789, "World!" };
        foreach (var item in a.OfType<string>()) Console.WriteLine(item.ToUpper());
    }
}

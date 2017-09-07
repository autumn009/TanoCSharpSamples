using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        object[] a = { 123, "Hello!", 456, 789, "World!" };
        foreach (var item in a.Where(c=>c is string).Cast<string>()) Console.WriteLine(item.ToUpper());
    }
}

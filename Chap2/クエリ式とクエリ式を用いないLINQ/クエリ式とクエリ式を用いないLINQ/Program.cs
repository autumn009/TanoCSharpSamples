using System;
using System.Linq;

class Program
{
    private static string[] getANames(string[] names)
    {
        return (from n in names where n.StartsWith("A") select n).ToArray();
    }

    static void Main(string[] args)
    {
        string[] names = { "Alice", "Anne", "Betty" };
        string[] r = getANames(names);
        foreach (var item in r) Console.WriteLine(item);
    }
}

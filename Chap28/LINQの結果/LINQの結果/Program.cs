using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] a = { "たろう", "じろう", "さぶろう" };
        var b = a.Where(c => c.Length >= 4);
        foreach (var item in b) Console.WriteLine(item);
    }
}

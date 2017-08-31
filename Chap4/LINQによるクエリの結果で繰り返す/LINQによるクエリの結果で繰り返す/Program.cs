using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var q = a.Where(c => c % 2 == 0);
        foreach (var item in q) Console.Write(item);
    }
}

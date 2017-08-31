using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3 };
        var q = from n in a select new { x = n, y = n * 2 };
        foreach (var item in q) Console.WriteLine("{0}*2={1}", item.x, item.y);
    }
}

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 1, 2, 3 };
        int[] b = a.Where(c => c == 1).Where(c => c == 2).ToArray();
        Console.WriteLine(b.Length);
    }
}

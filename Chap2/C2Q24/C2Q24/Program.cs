using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3 };
        foreach (var item in a.Where(c => c == 1).Where(c => c == 2))
            Console.WriteLine(item);
    }
}

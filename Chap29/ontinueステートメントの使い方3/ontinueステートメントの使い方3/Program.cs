using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5 };
        foreach (var item in a.Where(c => c != 3))
        {
            Console.Write(item);
        }
    }
}

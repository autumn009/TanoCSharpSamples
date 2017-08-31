using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        foreach (var item in a.Skip(2).Take(3)) Console.Write(item);
    }
}

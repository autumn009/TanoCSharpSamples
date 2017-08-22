using System;

class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3 };
        foreach (var item in System.Linq.Enumerable.Select(a, c => c * 2)) Console.WriteLine(item);
    }
}


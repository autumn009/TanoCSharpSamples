using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] a = { "たろう", "じろう", "さぶろう" };
        foreach (var item in a.Take(4)) Console.WriteLine(item);
    }
}

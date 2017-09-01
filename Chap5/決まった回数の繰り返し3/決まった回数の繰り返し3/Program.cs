using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        foreach (var i in Enumerable.Range(0, 10).Select(c => 9 - c)) Console.Write(i);
    }
}

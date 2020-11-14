using System;
using System.Collections;
using System.Collections.Generic;

class X
{
    internal int A { get; set; }
    internal int B { get; set; }
}

internal static class MyExtensions
{
    internal static IEnumerator GetEnumerator(this X x)
    {
        yield return x.A;
        yield return x.B;
    }
}

class Program
{
    static void Main()
    {
        var x = new X();
        foreach (var item in x) Console.WriteLine(item);
    }
}

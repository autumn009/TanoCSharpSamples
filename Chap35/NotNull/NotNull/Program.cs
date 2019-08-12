#nullable enable
using System;

public class A<T> where T:notnull
{
    internal int AddHashCode(T t1, T t2)
    {
        return t1.GetHashCode() + t2.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        var a = "Hello";
        var b = "World";
        var x = new A<string>();
        Console.WriteLine(x.AddHashCode(a, b));
        //string? c = null;
        //var y = new A<string?>();
        //Console.WriteLine(y.AddHashCode(a, c));
    }
}

using System;

class A
//struct A
{
    internal int X;
}

class Program
{
    private static void sample(A a)
    {
        a.X = 2;
    }
    static void Main(string[] args)
    {
        var a = new A() { X = 1 };
        sample(a);
        Console.WriteLine(a.X);
    }
}

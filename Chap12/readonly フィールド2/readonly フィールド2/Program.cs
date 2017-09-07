using System;

class A
{
    public readonly int a;
}

class Program
{
    static void Main(string[] args)
    {
        var x = new A() { a = 456 };
        Console.WriteLine(x.a);
    }
}

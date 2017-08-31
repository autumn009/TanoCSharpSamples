using System;

class A
{
    internal int N;
}

class Program
{
    static void Main(string[] args)
    {
        var a = new A();
        a.N = 123;
        Console.WriteLine(a.N);
    }
}

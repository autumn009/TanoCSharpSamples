using System;

class A
{
    internal int N;
    //internal int N { get; set; }
}

class Program
{
    private static void method(ref int x)
    {
        Console.WriteLine(x);
    }

    static void Main(string[] args)
    {
        var a = new A();
        a.N = 123;
        method(ref a.N);
    }
}

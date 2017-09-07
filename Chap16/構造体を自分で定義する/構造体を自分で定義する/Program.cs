using System;

struct A
{
    internal int N;
}

class Program
{
    static void Main(string[] args)
    {
        A x;
        x.N = 123;
        Console.WriteLine(x.N);
    }
}

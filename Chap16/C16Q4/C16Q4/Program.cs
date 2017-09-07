using System;

struct A
{
    internal int N;
}

class Program
{
    static void Main(string[] args)
    {
        A n1;
        n1.N = 123;
        A n2 = n1;
        n1.N = 456;
        Console.WriteLine(n2.N);
    }
}

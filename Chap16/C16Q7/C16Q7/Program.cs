using System;

static class X
{
    internal static void Init(out A a)
    {
        a.N = 456;
    }
}

struct A
{
    internal int N;
    internal A(int n)
    {
        N = n;
        X.Init(out this);
    }
}

class Program
{
    static void Main(string[] args)
    {
        A n = new A(123);
        Console.WriteLine(n.N);
    }
}

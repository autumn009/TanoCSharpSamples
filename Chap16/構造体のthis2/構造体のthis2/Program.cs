using System;

static class X
{
    internal static void Report(ref A a)
    {
        Console.WriteLine(a.N);
    }
}

struct A
{
    internal int N;
    internal void Report()
    {
        X.Report(ref this);
    }
    internal A(int n)
    {
        N = n;
    }
}

class Program
{
    static void Main(string[] args)
    {
        A n = new A(123);
        n.Report();
    }
}

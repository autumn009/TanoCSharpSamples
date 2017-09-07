using System;

struct A
{
    internal int N;
    internal A(int n)
    {
        N = n;
    }
}

class Program
{
    static void Main(string[] args)
    {
        A n1 = new A();
        Console.WriteLine(n1.N);
        A n2 = new A(123);
        Console.WriteLine(n2.N);
    }
}

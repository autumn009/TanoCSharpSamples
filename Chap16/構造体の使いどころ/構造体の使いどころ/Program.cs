using System;

class A
//struct A
{
    internal int N;
    public A(int n)
    {
        N = n;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var start = DateTime.Now;
        const int size = 50000000;
        A[] ar = new A[size];
        for (int i = 0; i < ar.Length; i++) ar[i] = new A(i);
        Console.WriteLine(DateTime.Now - start);
    }
}

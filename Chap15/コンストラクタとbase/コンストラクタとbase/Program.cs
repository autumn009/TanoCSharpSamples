using System;

class A
{
    public readonly int X;
    public A(int x)
    {
        X = x;
    }
}

class B : A
{
    public readonly int Y;
    public B(int x, int y)
        : base(x)
    {
        Y = y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        B b = new B(123, 456);
        Console.WriteLine("a.X = {0}", b.X);
        Console.WriteLine("a.Y = {0}", b.Y);
    }
}

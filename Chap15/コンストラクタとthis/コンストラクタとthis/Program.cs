using System;

class A
{
    public readonly int X;
    public readonly int Y;
    public A(int x)
    {
        X = x;
        Y = 0;
    }
    public A(int x, int y)
        : this(x)
    {
        Y = y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        A a = new A(123, 456);
        Console.WriteLine("a.X = {0}", a.X);
        Console.WriteLine("a.Y = {0}", a.Y);
    }
}

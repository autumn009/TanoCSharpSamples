using System;

class A
{
    public int X;
}

class B
{
    public readonly A y = new A();
}

class Program
{
    static void Main(string[] args)
    {
        var b = new B();
        b.y.X = 123;
        Console.WriteLine(b.y.X);
    }
}

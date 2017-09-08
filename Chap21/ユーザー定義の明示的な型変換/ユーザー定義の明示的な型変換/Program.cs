using System;

class A
{
    public int X;
    public int Y;
}

class B
{
    public int X;
    public static explicit operator B(A a)
    {
        return new B() { X = a.X * 10 + a.Y };
    }
}

class Program
{
    static void Main(string[] args)
    {
        A a = new A() { X = 1, Y = 2 };
        B b = (B)a;
        Console.WriteLine(b.X);
    }
}

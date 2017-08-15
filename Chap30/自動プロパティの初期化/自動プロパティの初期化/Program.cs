using System;

class A
{
    public int X = 123;
    public int Y { get; set; } = 123;
}


class Program
{
    static void Main(string[] args)
    {
        var a = new A();
        Console.WriteLine(a.X);
        Console.WriteLine(a.Y);
    }
}

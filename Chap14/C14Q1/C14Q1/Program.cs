using System;

class A
{
    internal static int B = 0;
    internal void CountUp()
    {
        A.B++;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new A();
        a.CountUp();
        var b = new A();
        b.CountUp();
        Console.WriteLine(A.B);
    }
}

using System;

public class A
{
    public int N { get; set; }
    public int Add(int x)
    {
        return N + x;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var a1 = new A();
        var a2 = new A();
        a1.N = 2;
        a2.N = 3;
        Console.WriteLine(a1.Add(4));
        Console.WriteLine(a2.Add(4));
    }
}

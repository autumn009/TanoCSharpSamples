using System;

public class A
{
    public int Add(int x, int y)
    {
        return x + y;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var a = new A();
        Console.WriteLine(a.Add(2, 3));
    }
}

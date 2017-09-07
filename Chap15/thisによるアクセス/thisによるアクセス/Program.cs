using System;

public class A
{
    private int x;
    public void Output()
    {
        Console.WriteLine(x);
    }
    public A(int x)
    {
        this.x = x;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var n = new A(1234);
        n.Output();
    }
}

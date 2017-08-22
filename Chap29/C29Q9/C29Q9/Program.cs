using System;

class X
{
    private int x = 123;
    public void Sample()
    {
        int x = 456;
        Console.WriteLine(x);
        Console.WriteLine(this.x);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var x = new X();
        x.Sample();
    }
}


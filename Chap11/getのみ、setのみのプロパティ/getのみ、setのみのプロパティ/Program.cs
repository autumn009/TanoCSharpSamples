using System;

class X
{
    private int myValue;
    public int A
    {
        set { myValue = value; }
    }
    public int B
    {
        get { return myValue; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new X();
        a.A = 123;
        Console.WriteLine(a.B);
    }
}

using System;

class TwoWaysClass
{
    private int myValue;
    public int A
    {
        get { return myValue; }
        set { myValue = value; }
    }
    public int B
    {
        get { return myValue; }
        set { myValue = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new TwoWaysClass();
        a.A = 123;
        Console.WriteLine(a.B);
    }
}

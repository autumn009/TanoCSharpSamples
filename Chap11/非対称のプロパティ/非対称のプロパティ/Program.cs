using System;

class X
{
    private int myValue;
    public int A
    {
        protected set { myValue = value; }
        get { return myValue; }
    }
}

class Y : X
{
    public Y()
    {
        A = 123;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new Y();
        Console.WriteLine(a.A);
    }
}

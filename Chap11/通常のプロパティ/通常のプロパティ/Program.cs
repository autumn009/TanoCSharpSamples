using System;

class A
{
    private int myValue;
    public int MyProperty
    {
        get
        {
            return myValue;
        }
        set
        {
            myValue = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new A();
        a.MyProperty = 123;
        Console.WriteLine(a.MyProperty);
    }
}

using System;

interface A
{
    void MyMethod();
}

class B : A
{
    public void MyMethod()
    {
        Console.WriteLine("in B:MyMethod");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var obj = new B();
        obj.MyMethod();
    }
}

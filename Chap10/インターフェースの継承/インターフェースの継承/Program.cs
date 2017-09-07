using System;

interface A
{
    void MyMethodA();
}

interface B : A
{
    void MyMethodB();
}

internal class C : B
{
    public void MyMethodB()
    {
        Console.WriteLine("in C:MyMethodB");
    }

    public void MyMethodA()
    {
        Console.WriteLine("in C:MyMethodA");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new C();
        a.MyMethodA();
        a.MyMethodB();
    }
}

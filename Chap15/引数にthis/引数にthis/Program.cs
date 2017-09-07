using System;

class A
{
    public void MethodA(B b)
    {
        Console.WriteLine(b.Data);
    }
}

class B
{
    public void MethodB()
    {
        var a = new A();
        a.MethodA(this);
    }
    public string Data = "I'm in class B!";
}

class Program
{
    static void Main(string[] args)
    {
        B b = new B();
        b.MethodB();
    }
}

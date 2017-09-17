using System;

interface A
{
    void MyMethodA();
}
interface B
{
    void MyMethodB();
}

class C : A, B
{
    public void MyMethodA()
    {
        Console.WriteLine("in C:MyMethodA");
    }
    public void MyMethodB()
    {
        Console.WriteLine("in C:MyMethodB");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var obj = new C();
        obj.MyMethodA();
        obj.MyMethodB();
    }
}

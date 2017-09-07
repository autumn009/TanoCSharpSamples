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
        Console.WriteLine("in B:MyMethodA");
    }
    public void MyMethodB()
    {
        Console.WriteLine("in B:MyMethodB");
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

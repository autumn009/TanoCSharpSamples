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

    void A.MyMethod()
    {
        Console.WriteLine("in B:A.MyMethod");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var obj = new B();
        obj.MyMethod();
        A objTypeA = obj;
        objTypeA.MyMethod();
    }
}

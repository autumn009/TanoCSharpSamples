using System;

interface A
{
    void MyMethod1();
    void MyMethod2(int x);
    void MyMethod3(int x, int y);
}

internal class B : A
{
    public void MyMethod3(int x, int y)
    {
        Console.WriteLine(x + y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new B();
        a.MyMethod3(2, 3);
    }
}

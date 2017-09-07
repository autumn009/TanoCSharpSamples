using System;

/*sealed*/ class A
{
    public void MyMethod1()
    {
        Console.WriteLine("in A:MyMethod1");
    }
}

// 以下のクラスは作成できない
class B : A
{
    public void MyMethod2()
    {
        Console.WriteLine("in B:MyMethod2");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var x = new B();
        x.MyMethod1();
        x.MyMethod2();
    }
}

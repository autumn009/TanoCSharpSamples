using System;

class A
{
    public void Hello()
    {
        Console.WriteLine("Hello! I'm A");
    }
}

class B<T>
//class B<T> where T : A
{
    public void CallT(T a)
    {
        a.Hello();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new A();
        var b = new B<A>();
        b.CallT(a);
    }
}

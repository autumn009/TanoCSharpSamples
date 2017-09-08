using System;

class A : IDisposable
{
    public A()
    {
        Console.WriteLine("Created");
    }
    public void DoIt()
    {
        Console.WriteLine("Do it!");
    }
    void IDisposable.Dispose()
    {
        Console.WriteLine("Disposed");
    }
}

class Program
{
    static void Main(string[] args)
    {
        using (A a = new A())
        {
            a.DoIt();
        }
    }
}

using System;

class A<T>
//class A<T> where T : new()
{
    public T HelloNew()
    {
        return new T();
    }
}

class B { }

class Program
{
    static void Main(string[] args)
    {
        var a = new A<B>();
        var r = a.HelloNew();
        Console.WriteLine(r.GetType().FullName);
    }
}


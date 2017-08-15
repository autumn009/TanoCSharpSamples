using System;
using System.Collections.Generic;

class A : IEnumerable<int>
{
    IEnumerator<int> IEnumerable<int>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

static class S
{
    public static void Add(this A a, int x)
    {
        Console.WriteLine("Added:" + x);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new A() { 111, 222, 333, 444, 555, 666, 777, 888, 999 };
    }
}

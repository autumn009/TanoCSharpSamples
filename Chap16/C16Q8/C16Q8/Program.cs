using System;

struct A { }

class Program
{
    static void Main(string[] args)
    {
        A n = new A();
        Console.WriteLine(n is System.ValueType);
        Console.WriteLine(n is System.Object);
    }
}

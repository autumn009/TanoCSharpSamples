using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        dynamic obj = new ExpandoObject();
        obj.A = 123;
        obj.B = 456;
        Console.WriteLine(obj.A + obj.b);
    }
}

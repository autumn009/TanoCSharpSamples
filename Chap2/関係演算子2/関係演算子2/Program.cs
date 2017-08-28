using System;

class Program
{
    static void Main(string[] args)
    {
        object a = new object();
        object b = new object();
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
        Console.WriteLine(a == a);
        Console.WriteLine(a != a);
    }
}

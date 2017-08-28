using System;

class Program
{
    static void Main(string[] args)
    {
        object a = new string('a', 2);
        object b = "aa";
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
    }
}

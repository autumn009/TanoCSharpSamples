using System;

class Program
{
    static void Main(string[] args)
    {
        string a = new string('a', 2);
        string b = "aa";
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
    }
}

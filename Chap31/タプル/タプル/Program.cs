using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("pattern 1");
        var x1 = ("a", "b");
        Console.Write(x1.Item1);
        Console.WriteLine(x1.Item2);

        Console.WriteLine("pattern 2");
        (string First, string Second) x2 = ("c", "d");
        Console.Write(x2.First);
        Console.WriteLine(x2.Second);
        Console.Write(x2.ToTuple().Item1);
        Console.WriteLine(x2.ToTuple().Item2);

        Console.WriteLine("pattern 3");
        var x3 = (First: "e", Second: "f");
        Console.Write(x3.First);
        Console.WriteLine(x3.Second);
        Console.Write(x3.ToTuple().Item1);
        Console.WriteLine(x3.ToTuple().Item2);
    }
}

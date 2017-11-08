using System;

readonly struct Example
{
    public int MyProperty1 { get; }
}


class Program
{
    static void Main(string[] args)
    {
        var e = new Example();
        Console.WriteLine(e.MyProperty1);
    }
}

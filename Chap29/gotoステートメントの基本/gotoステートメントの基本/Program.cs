using System;

class Program
{
    static void Main(string[] args)
    {
        goto mylabel;
        Console.WriteLine("Skipped!");
        mylabel: Console.WriteLine("Jumped!");
    }
}

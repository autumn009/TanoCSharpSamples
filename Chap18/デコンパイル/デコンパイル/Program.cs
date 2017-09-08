using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] messages =
        {
            "Hello",
            "World",
            "たけやぶやけた"
        };
        string s = messages[new Random().Next(messages.Length)];
        foreach (var c in s.Reverse()) Console.Write(c);
        Console.WriteLine();
    }
}


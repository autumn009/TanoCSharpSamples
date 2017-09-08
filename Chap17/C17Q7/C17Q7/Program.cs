using System;

class Program
{
    static void Main(string[] args)
    {
        string a = null;
        string b = "I'm B";
        string c = null;
        Console.WriteLine(a ?? b ?? c ?? "Hello!");
    }
}

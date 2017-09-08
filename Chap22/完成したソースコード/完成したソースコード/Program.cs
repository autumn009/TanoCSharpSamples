using System;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        Console.WriteLine(name == "" ? "名無し" : name);
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        int? a = null;
        Console.WriteLine(a ?? "ありません");
    }
}

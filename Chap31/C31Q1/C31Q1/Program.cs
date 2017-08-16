using System;
class Program
{
    static void Main(string[] args)
    {
        if (int.TryParse("123", out int r)) Console.WriteLine(r);
        Console.WriteLine(r);
    }
}

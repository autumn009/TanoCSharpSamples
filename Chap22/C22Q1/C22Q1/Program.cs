using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 1 != 1 ? 2 : 3 == 3 ? 4 : 5;
        Console.WriteLine(a);
    }
}

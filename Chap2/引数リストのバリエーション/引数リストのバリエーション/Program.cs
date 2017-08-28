using System;

class Program
{
    static void Main(string[] args)
    {
        Func<int, int> x1 = (a) => a * 3; // ①
        Func<int, int> x2 = (int a) => a * 3; // ②
        Func<int, int> x3 = a => a * 3; // ③
        Console.WriteLine(x1(2));
        Console.WriteLine(x2(2));
        Console.WriteLine(x3(2));
    }
}

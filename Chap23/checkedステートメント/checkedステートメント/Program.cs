
using System;

public class Program
{
    static void Main(string[] args)
    {
        int a = int.MaxValue, b = 1;
        checked
        {
            Console.WriteLine(a + b);
        }
    }
}

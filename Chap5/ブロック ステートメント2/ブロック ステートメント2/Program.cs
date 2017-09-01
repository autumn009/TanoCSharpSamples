using System;

public class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3 };
        foreach (int item in a)
        {
            Console.WriteLine(item);
            Console.WriteLine("a");
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5 };
        foreach (var item in a)
        {
            if (item == 3) break;
            Console.Write(item);
        }
    }
}

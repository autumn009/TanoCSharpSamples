using System;

class Program
{
    static void Main(string[] args)
    {
        object[] array = { 1, 2, 3 };
        foreach (int item2 in (int[])array)
        {
            Console.WriteLine(item2);
        }
    }
}

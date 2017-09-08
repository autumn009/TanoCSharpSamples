using System;

class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int a = int.MaxValue;
            Console.WriteLine(a + 1);
        }
    }
}

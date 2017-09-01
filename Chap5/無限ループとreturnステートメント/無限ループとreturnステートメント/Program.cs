using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        for (; ; )
        {
            if (i > 100) return;
            Console.WriteLine(i);
            i = i * 2;
        }
    }
}

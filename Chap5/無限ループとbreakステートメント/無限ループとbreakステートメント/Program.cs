using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        for (; ; )
        {
            Console.Write("{0}", i++);
            if (i >= 10) break;
        }
    }
}

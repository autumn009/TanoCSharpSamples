using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 10;
        goto MyLabel;
        for (i = 0; i < 10; i++)
        {
            MyLabel:
            Console.WriteLine(i);
        }
    }
}

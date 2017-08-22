using System;

class Program
{
    static void Main(string[] args)
    {
        switch (1)
        {
            case 1:
                Console.WriteLine("Y");
                goto case 2; // ←書き足した
            case 2:
                Console.WriteLine("X");
                break;
        }
    }
}

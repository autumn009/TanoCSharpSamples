using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        foreach (var i in Enumerable.Range(1, 5))
        {
            switch (i)
            {
                case 1:
                    Console.Write("A");
                    goto case 3;
                case 2:
                    Console.Write("B");
                    goto case 3;
                case 3:
                    Console.Write("C");
                    goto default;
                case 4:
                    Console.Write("D");
                    goto default;
                default:
                    Console.WriteLine("E");
                    break;
            }
        }
    }
}

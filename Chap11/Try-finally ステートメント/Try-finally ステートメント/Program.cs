using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("in try-block");
            return;
            Console.WriteLine("never execute");
        }
        finally
        {
            Console.WriteLine("finally");
        }
    }
}

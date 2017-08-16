using System;

class Program
{
    static void Main(string[] args)
    {
        object[] ar = { 0, 1, "2", 3 };
        foreach (var a in ar)
        {
            switch (a)
            {
                case 0:
                    Console.WriteLine("ZERO");
                    break;
                case 1:
                    Console.WriteLine("ONE");
                    break;
                case int n:
                    Console.WriteLine(n);
                    break;
            }
        }
    }
}

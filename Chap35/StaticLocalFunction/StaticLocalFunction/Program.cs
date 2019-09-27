using System;

class Program
{
    static void Main()
    {
        int a = 4, b = 2;
        Console.WriteLine(calcAve1());
        Console.WriteLine(calcAve2(a, b));

        int calcAve1()
        {
            return (a + b) / 2;
        }
        static int calcAve2(int x, int y)
        {
            return (x + y) / 2;
        }
    }
}

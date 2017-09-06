using System;

class Program
{
    private static void sample(double from, double to)
    {
        // double型では精度が不足して誤差が出ていくので、
        // より精度の高いdecimal型でカウントする
        for (decimal i = (decimal)from; i < (decimal)to; i += 0.1m)
        {
            Console.Write("{0},", i);
        }
    }

    static void Main(string[] args)
    {
        sample(0.0, 100.0);
    }
}

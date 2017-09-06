using System;

class Program
{
    private static void sample(double from, double to)
    {
        // 10倍の下駄をはかせる
        for (int i = (int)(from * 10); i < (int)(to * 10); i++)
        {
            // 下駄を脱ぐ　(10で割る)
            Console.Write("{0},", (double)i / 10.0);
        }
    }

    static void Main(string[] args)
    {
        sample(0.0, 100.0);
    }
}

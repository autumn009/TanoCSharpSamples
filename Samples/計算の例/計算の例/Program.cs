using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(args[0]);
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine("{0}は{1}で割り切れるので、素数ではありません。", n, i);
                return;
            }
        }
        Console.WriteLine("{0}は素数です。", n);
    }
}

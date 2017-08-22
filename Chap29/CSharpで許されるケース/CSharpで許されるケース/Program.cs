using System;

class Program
{
    private static void sample(int from, int to)
    {
        if (from < 0) goto MyError;
        for (int i = from; i < to; i++)
        {
            if (i > 5) goto MyError;
            Console.WriteLine(i);
        }
        return;
        MyError:
        Console.WriteLine("エラー発生");
    }

    static void Main(string[] args)
    {
        sample(0, 10);
    }
}

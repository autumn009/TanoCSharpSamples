using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        const int COUNT1 = 9999;
        const int COUNT2 = 10000000;
        var list = new Action[COUNT1];
        for (int i = 0; i < COUNT1; i++)
        {
            int j = i;
            int[] k = new int[COUNT2];
            int x = k[j];
            list[j] = () =>
            {
                Console.WriteLine(x);
            };
        }
        list.First()();
        list.Last()();
    }
}

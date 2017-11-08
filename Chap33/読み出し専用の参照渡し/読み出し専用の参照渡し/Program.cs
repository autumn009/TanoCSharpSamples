using System;

struct Large
{
    internal decimal a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z;
}

class Program
{
    private static void sub1(Large para)
    {
    }
    private static void sub2(in Large para)
    {
    }

    static void Main(string[] args)
    {
        Large large = new Large();
        int length = 100000000;
        Console.WriteLine("Normal parameter");
        var start1 = DateTime.Now;
        for (int i = 0; i < length; i++) sub1(large);
        Console.WriteLine(DateTime.Now - start1);
        Console.WriteLine("Read Only Reference parameter");
        var start2 = DateTime.Now;
        for (int i = 0; i < length; i++) sub2(in large);
        Console.WriteLine(DateTime.Now - start2);
    }
}

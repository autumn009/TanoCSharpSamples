using System;

class Program
{
    static void Main(string[] args)
    {
        string[] ar =
        {
            "Windows",
            "Hello",
            "World",
            "Series",
            "End"
        };

        Index i1 = 1;
        Index i2 = 3;
        Index i3 = ^2;
        // インデックスがi1の値
        Console.WriteLine(ar[i1]);
        // インデックスがi2の値
        Console.WriteLine(ar[i2]);
        // インデックスがi3の値
        Console.WriteLine(ar[i3]);
        // インデックスが1～3の範囲
        var r1 = ar[1..3];
        foreach (var item in r1) Console.Write(item);
        Console.WriteLine();
        // インデックスがi1～i2の範囲(i2は含まない)
        var r2 = ar[i1..i2];
        foreach (var item in r2) Console.Write(item);
        Console.WriteLine();
        // インデックスがi1～i3の範囲(i3は含まない)
        var r3 = ar[i1..i3];
        foreach (var item in r3) Console.Write(item);
        Console.WriteLine();
    }
}

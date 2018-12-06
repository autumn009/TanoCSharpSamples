using System;

class Program
{
    private static char[] ar = { 'P', 'E', 'N', 'D', 'U', 'L', 'U', 'M' };
    private static void sub(string label, Range range)
    {
        Console.Write($"{label}: ");
        var r1 = ar[range];
        foreach (var item in r1) Console.Write(item);
        Console.WriteLine();
    }

    static void Main()
    {
        Index i1 = 1;
        Index i2 = 3;
        Index i3 = ^2;
        Console.WriteLine($"インデックスがi1(1)の値: {ar[i1]}");
        Console.WriteLine($"インデックスがi2(3)の値: {ar[i2]}");
        Console.WriteLine($"インデックスがi3(^2)の値: {ar[i3]}");

        sub("インデックスが1～3の範囲", 1..3);
        sub("インデックスがi1(1)～i2(3)の範囲(i2は含まない)", i1..i2);
        sub("インデックスがi1(1)～i3(^2)の範囲(i3は含まない)", i1..i3);
        sub("インデックスが2～の範囲", 2..);
        sub("インデックスが～3の範囲", ..3);
        sub("インデックスが～^3の範囲", ..^3);
        sub("インデックスが完全オープン(..)の範囲", ..);
    }
}

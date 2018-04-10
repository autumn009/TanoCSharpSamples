using System;

class Program
{
    static void Main(string[] args)
    {
        var a = 1;
        var b = 2;
        var c = 3;
        ref var x = ref a;
        x = ref b;
        x = c;
        Console.Write($"a={a},b={b},c={c},x={x}");
    }
}

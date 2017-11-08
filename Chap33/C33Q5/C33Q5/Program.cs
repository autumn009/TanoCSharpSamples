using System;
class Program
{
    private static ref T choice<T>(bool condition, ref T consequence, ref T alternative)
    {
        if (condition)
            return ref consequence;
        else
            return ref alternative;
    }

    static void Main(string[] args)
    {
        int[] ar = { 1, 2, 3 };
        int[] ar2 = { 1, 2, 3 };
        ref var x = ref choice(ar != null, ref ar[0], ref ar2[0]);
        x = 4;
        foreach (var item in ar) Console.Write($"{item} ");
    }
}

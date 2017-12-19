using System;
class Program
{
    static void Main(string[] args)
    {
        int[] ar = { 1, 2, 3 };
        ref var x = ref (ar[0] == 0 ? ref ar[1] : ref ar[2]);
        x = 4;
        foreach (var item in ar) Console.Write($"{item} ");
    }
}

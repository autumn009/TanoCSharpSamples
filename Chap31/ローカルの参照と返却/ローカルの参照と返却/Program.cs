using System;
class Program
{
    private static ref int sub(int[] array, int index)
    {
        return ref array[index];
    }

    static void Main(string[] args)
    {
        int[] ar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        ref var r = ref sub(ar, 5);
        Console.WriteLine(ar[5]);
        r = -r;
        Console.WriteLine(ar[5]);
    }
}

using System;

class Program
{
    private static ref int sub()
    {
        int x = 123;
        return ref x;
    }

    static void Main(string[] args)
    {
        ref var a = ref sub();
        Console.WriteLine(a);
    }
}

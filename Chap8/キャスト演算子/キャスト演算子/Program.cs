using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 127;
        sbyte b = a;	// ←ここ
        //sbyte b = (sbyte)a;
        Console.WriteLine(b);
    }
}

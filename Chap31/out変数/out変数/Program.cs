using System;
class Program
{
    static void Main(string[] args)
    {
        // C# ～6.0
        int r1;
        if (int.TryParse("123", out r1)) Console.WriteLine(r1);

        // C# 7.0～
        if (int.TryParse("123", out int r2)) Console.WriteLine(r2);
    }
}

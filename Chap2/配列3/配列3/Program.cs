using System;
using System.Linq;

class Program
{
    private static void Calclation(int[] kosu)
    {
        Console.WriteLine(kosu.Sum());
    }

    static void Main(string[] args)
    {
        var kosu = new int[3];
        kosu[0] = 3;
        kosu[1] = 2;
        kosu[2] = 4;
        Calclation(kosu);
    }
}

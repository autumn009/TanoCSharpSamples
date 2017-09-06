using System;

class Program
{
    enum Packed
    {
        Info1 = 1,
        Info2 = 2,
        Info3 = 4,
    }

    static void Main(string[] args)
    {
        Packed p = Packed.Info1 | Packed.Info3;

        if ((p & Packed.Info2) != 0)
        //if (p.HasFlag(Packed.Info2))
            Console.WriteLine("Info2があります");
        else
            Console.WriteLine("Info2がありません");
    }
}

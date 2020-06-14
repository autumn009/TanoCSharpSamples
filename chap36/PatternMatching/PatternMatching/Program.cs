using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static bool IsLetterOld(char c) => c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z';
    static bool IsLetterNew(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
    static void Main()
    {
        // and/or sample
        for (int i = 0; i < 0xff; i++) Console.Write($"{(IsLetterOld((char)i) ? '1' : '0')}");
        Console.WriteLine();
        for (int i = 0; i < 0xff; i++) Console.Write($"{(IsLetterNew((char)i) ? '1' : '0')}");
        Console.WriteLine();

        // is not null
        object a1 = null, a2 = "";
        bool b1 = a1 is not null;
        bool b2 = a2 is not null;
        Console.WriteLine($"{b1},{b2}");

        // is int and/or
        test(1);
        test(101);
        test("1");
        void test(object p)
        {
            if (p is int x and <= 100)
                Console.WriteLine($"{p}+1 is {x + 1}");
            else
                Console.WriteLine($"{p} is not the condition");
        }
    }
}

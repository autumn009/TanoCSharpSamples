using System;

class Program
{
    static void Main(string[] args)
    {
        foreach (var item in args[0])
        {
            if (item >= 'A' && item <= 'Z')
                Console.Write((char)((item - 'A' + 13) % 26 + 'A'));
            else if (item >= 'a' && item <= 'z')
                Console.Write((char)((item - 'a' + 13) % 26 + 'a'));
            else
                Console.Write(item);
        }
        Console.WriteLine();
    }
}

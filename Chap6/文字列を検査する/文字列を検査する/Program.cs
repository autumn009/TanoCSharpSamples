using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        char ch1 = 'A';
        bool found1 = "ACE".Contains(ch1);
        Console.WriteLine("{0}の検索結果: {1}", ch1, found1);
        char ch2 = 'B';
        bool found2 = "ACE".Contains(ch2);
        Console.WriteLine("{0}の検索結果: {1}", ch2, found2);
    }
}

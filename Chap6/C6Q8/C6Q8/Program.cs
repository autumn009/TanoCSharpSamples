using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string s = "HELLO!";
        Console.WriteLine(s.Count(c => c == 'L'));
    }
}

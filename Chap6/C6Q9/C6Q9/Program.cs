using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string s = "たからばこ";
        foreach (var item in s.Where(c => c != 'た')) Console.Write(item);
    }
}


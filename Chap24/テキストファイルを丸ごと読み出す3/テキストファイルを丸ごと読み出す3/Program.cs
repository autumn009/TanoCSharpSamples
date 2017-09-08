using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string filename = @"s:\delme.txt";
        string s = File.ReadAllText(filename, Encoding.Default);
        Console.WriteLine(s);
    }
}

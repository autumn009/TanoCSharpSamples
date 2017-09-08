using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filename = @"s:\delme.txt";  // ←自由にファイル名は指定して良い
        string s = File.ReadAllText(filename);
        Console.WriteLine(s);
    }
}

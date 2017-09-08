using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string filename = @"s:\delme.txt";  // ←自由にファイル名は指定して良い
        string encodeName = "Shift_JIS";  // ←自由にエンコード名は指定して良い
        string s = File.ReadAllText(filename, Encoding.GetEncoding(encodeName));
        Console.WriteLine(s);
    }
}

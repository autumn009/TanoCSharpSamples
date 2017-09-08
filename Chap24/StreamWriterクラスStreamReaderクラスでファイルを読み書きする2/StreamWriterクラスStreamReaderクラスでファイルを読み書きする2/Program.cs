using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string filename = @"s:\delme.txt";  // ←自由にファイル名は指定して良い
        string encodeName = "Shift_JIS";  // ←自由にエンコード名は指定して良い
        var writer = new StreamWriter(filename, false, Encoding.GetEncoding(encodeName));
        writer.WriteLine("This is a first line!");
        writer.WriteLine("This is a 2nd line!");
        writer.Close();
        var reader = new StreamReader(filename, Encoding.GetEncoding(encodeName));
        Console.WriteLine(reader.ReadLine());
        reader.Close();
    }
}

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(File.ReadAllText("settings.txt"));
        }
        catch (FileNotFoundException e) when(!e.FileName.Contains("settings.txt"))
        {
            Console.WriteLine(e);
        }
    }
}


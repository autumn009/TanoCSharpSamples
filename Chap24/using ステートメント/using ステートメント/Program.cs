using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        using (var stream = new StreamWriter(@"sample.txt"))
        {
            stream.WriteLine("written from C# program");
        }
    }
}

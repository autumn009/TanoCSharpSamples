using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        var stream = new StreamWriter(@"sample.txt");
        using (stream)
        {
            stream.WriteLine("part-1");
        }
        stream.WriteLine("part-2");
        stream.Close();
    }
}

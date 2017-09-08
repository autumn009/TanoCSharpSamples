using System;
using System.IO;

public class Program
{
    private static void write()
    {
        using (var stream = new StreamWriter(@"sample.txt"))
        {
            stream.WriteLine("written from C# program");
            return;
        }
    }
    private static void read()
    {
        using (var stream = new StreamReader(@"sample.txt"))
        {
            Console.WriteLine(stream.ReadLine());
            return;
        }
    }
    static void Main(string[] args)
    {
        write();
        read();
    }
}

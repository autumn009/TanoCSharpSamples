using System;
using System.IO;

public class Program
{
    private static void write()
    {
        using (var stream = new StreamWriter(@"sample.txt"))
        {
            stream.WriteLine("written from C# program");
            throw new ApplicationException();
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
        try
        {
            write();
        }
        catch (ApplicationException)
        {
            Console.WriteLine("例外発生!");
        }
        read();
    }
}

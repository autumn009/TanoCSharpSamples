using System;
using System.IO;

class Program
{
    static void Main()
    {
        var s = "One\r\nTwo\r\nThree";
        // old pattern
        using (var reader1 = new StringReader(s))
        {
            Console.WriteLine(reader1.ReadToEnd());
        }
        // new pattern
        using var reader2 = new StringReader(s);
        Console.WriteLine(reader2.ReadToEnd());
    }
}

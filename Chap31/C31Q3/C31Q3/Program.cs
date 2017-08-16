using System;

class Program
{

    static void Main(string[] args)
    {
        var s = "123";
        Console.Write("{0}はint型として解析でき", s);
        if( int.TryParse(s, out _) )
            Console.WriteLine("ます。");
        else
            Console.WriteLine("ません。");
    }
}

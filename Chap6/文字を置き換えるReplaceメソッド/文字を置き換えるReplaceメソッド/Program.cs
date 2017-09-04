using System;

class Program
{
    static void Main(string[] args)
    {
        var s = "*くん、*くん。君の名前は*だろ?";
        var r = s.Replace("*", "たろう");
        Console.WriteLine(r);
    }
}

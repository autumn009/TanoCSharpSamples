using System;

public enum Sex { 男, 女, ニューハーフ };

class Program
{
    static void Main(string[] args)
    {
        var a = Sex.男;
        var b = Sex.ニューハーフ;
        Console.WriteLine(a == b);
    }
}

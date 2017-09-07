using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var dic = new Dictionary<string, string>();
        dic["ミカン"] = "果物屋";
        dic["ダイコン"] = "八百屋";
        Console.WriteLine(dic["ミカン"]);
        Console.WriteLine(dic["ダイコン"]);
    }
}

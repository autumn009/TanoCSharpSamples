using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> newStyle = new Dictionary<string, string>
        {
            ["X"] = "A",
            [@"X"] = "B",
            ["\u0058"] = "C",
        };
        foreach (var item in newStyle) Console.Write(item.Value);
    }
}

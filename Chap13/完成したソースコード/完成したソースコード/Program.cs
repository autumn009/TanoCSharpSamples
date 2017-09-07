using System;
using System.Collections.Generic;

class 連想配列
{
    private List<string> keys = new List<string>();
    private List<string> values = new List<string>();
    public string this[string index]
    {
        get
        {
            for (int i = 0; i < keys.Count; i++)
            {
                if (keys[i] == index) return values[i];
            }
            return null;
        }
        set
        {
            for (int i = 0; i < keys.Count; i++)
            {
                if (keys[i] == index)
                {
                    values[i] = value;
                    return;
                }
            }
            keys.Add(index);
            values.Add(value);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var dic = new 連想配列();
        dic["ミカン"] = "果物屋";
        dic["ダイコン"] = "八百屋";
        Console.WriteLine(dic["ミカン"]);
        Console.WriteLine(dic["ダイコン"]);
    }
}

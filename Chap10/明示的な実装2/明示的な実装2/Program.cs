using System;
using System.Collections.Generic;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        var obj = new ExpandoObject();
        var col = obj as ICollection<KeyValuePair<string, Object>>;
        col.Add(new KeyValuePair<string, object>("MESSAGE", "4949"));
        foreach (var item in obj)
        {
            Console.WriteLine("{0}={1}", item.Key, item.Value);
        }
    }
}

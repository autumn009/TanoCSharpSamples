using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class X
{
    [field: NonSerialized]
    public int x { get; set; }
}


class Program
{
    static void Main(string[] args)
    {
        X obj = new X();
        IFormatter formatter = new BinaryFormatter();
        var stream = new MemoryStream();
        formatter.Serialize(stream, obj);
        Console.Write($"data size is {stream.ToArray().Length} bytes.");
    }
}

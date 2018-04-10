using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;

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
        IFormatter formatter = new SoapFormatter();
        var stream = new MemoryStream();
        formatter.Serialize(stream, obj);
        Console.Write(Encoding.UTF8.GetString(stream.ToArray()));
    }
}

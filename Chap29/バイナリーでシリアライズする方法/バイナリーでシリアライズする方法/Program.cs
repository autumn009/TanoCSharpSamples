using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class X
{
    public string s1 = "initial data";
    [NonSerialized]
    public string s2 = "initial data";
}

class Program
{
    static void Main(string[] args)
    {
        const string filename = "samplefile.bin";
        var x = new X();
        x.s1 = "rewrited data";
        BinaryFormatter formatter = new BinaryFormatter();
        using (var stream = File.Create(filename))
        {
            formatter.Serialize(stream, x);
        }
        using (var stream = File.OpenRead(filename))
        {
            X o = (X)formatter.Deserialize(stream);
            Console.WriteLine("s1={0}", o.s1);
            Console.WriteLine("s2={0}", o.s2);
        }
    }
}

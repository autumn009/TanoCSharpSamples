using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

[DataContract]
class X
{
    [DataMember]
    public string s1 = "initial data";
    // DataMember属性は付いていない
    public string s2 = "initial data";
}

class Program
{
    static void Main(string[] args)
    {
        const string filename = "samplefile.json";
        var x = new X();
        x.s1 = "rewrited data";
        var ds = new DataContractJsonSerializer(typeof(X));
        using (var stream = File.Create(filename))
        {
            ds.WriteObject(stream, x);
        }

        using (var stream = File.OpenRead(filename))
        {
            X o = (X)ds.ReadObject(stream);
            Console.WriteLine("s1={0}", o.s1);
            Console.WriteLine("s2={0}", o.s2);
        }
    }
}

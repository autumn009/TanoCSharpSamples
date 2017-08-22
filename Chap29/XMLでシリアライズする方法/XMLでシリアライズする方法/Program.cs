using System;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;

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
        const string filename = "samplefile.xml";
        var x = new X();
        x.s1 = "rewrited data";
        var ds = new DataContractSerializer(typeof(X));
        using (var xw = XmlWriter.Create(filename))
        {
            ds.WriteObject(xw, x);
        }

        using (var xw = XmlReader.Create(filename))
        {
            X o = (X)ds.ReadObject(xw, false);
            Console.WriteLine("s1={0}", o.s1);
            Console.WriteLine("s2={0}", o.s2);
        }
    }
}

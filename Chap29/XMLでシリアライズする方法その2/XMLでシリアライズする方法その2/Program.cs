using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class X
{
    public string s1 = "initial data";
    [XmlIgnore]
    public string s2 = "initial data";
}

class Program
{
    static void Main(string[] args)
    {
        const string filename = "samplefile.xml";
        var x = new X();
        x.s1 = "rewrited data";
        XmlSerializer serializer = new XmlSerializer(typeof(X));
        using (var stream = XmlWriter.Create(filename))
        {
            serializer.Serialize(stream, x);
        }
        using (var stream = XmlReader.Create(filename))
        {
            X o = (X)serializer.Deserialize(stream);
            Console.WriteLine("s1={0}", o.s1);
            Console.WriteLine("s2={0}", o.s2);
        }
    }
}

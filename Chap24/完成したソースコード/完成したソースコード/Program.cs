using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string encodeName = "UTF-8";            // ←名前は自由に書き換えて良い
        string filename1 = @"s:\delme.txt";     // ←名前は自由に書き換えて良い
        string filename2 = @"s:\delme1.txt";    // ←名前は自由に書き換えて良い
        Encoding encoding = Encoding.GetEncoding(encodeName);
        using (var reader = new StreamReader(filename1, encoding))
        {
            using (var writer = new StreamWriter(filename2, false, encoding))
            {
                for (; ; )
                {
                    string s = reader.ReadLine();
                    if (s == null) break;
                    writer.WriteLine(s.ToUpper());
                }
            }
        }
    }
}

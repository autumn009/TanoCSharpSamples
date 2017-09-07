using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(int.Parse("XYZ"));
        }
        catch (FormatException)
        {
            Console.WriteLine("指定文字列が間違っているので処理できません。");
        }
        catch (IOException)
        {
            Console.WriteLine("出力できません。");
        }
    }
}

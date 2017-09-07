using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(int.Parse("XYZ"));
        }
        catch (Exception)
        {
            Console.WriteLine("指定文字列が間違っているので処理できません。");
        }
        finally
        {
            Console.WriteLine("finally");
        }
    }
}

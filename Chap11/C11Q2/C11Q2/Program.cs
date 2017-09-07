using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            try
            {
                Console.WriteLine(int.Parse("XYZ"));
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("指定文字列が間違っているので処理できません。");
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(int.Parse("XYZ"));
        }
        catch (Exception e)
        {
            Console.WriteLine("指定文字列が間違っているので処理できません。({0})", e.Message);
        }
        //catch (Exception)
        //{
        //Console.WriteLine("指定文字列が間違っているので処理できません。");
        //}
    }
}

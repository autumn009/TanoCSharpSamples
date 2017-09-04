using System;

class Program
{
    static void Main(string[] args)
    {
        string s = "ABCD";
        //string s = "1234";
        int a;
        if (int.TryParse(s, out a)) Console.WriteLine(a);
        else Console.WriteLine("int.TryParseメソッドの実行に失敗しました。");
    }
}

#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    private static string? s = string.Empty;
    [DisallowNull]
    public static string? MyProperty
    {
        get { return s; }
        set { s = value; }
    }

    public static void ShowStringLength(string s)
    {
        Console.WriteLine(s.Length);
    }
    static void Main(string[] args)
    {
        // null リテラルを null 非許容参照型に変換できません。
        MyProperty = null;
        // パラメーター 's' に Null 参照引数がある可能性があります
        ShowStringLength(MyProperty);
    }
}

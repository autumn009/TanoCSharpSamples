using System;

// この定義は将来のバージョンで不要になる見込みである
// エラーになる場合は削除してみると良い
namespace System.Runtime.CompilerServices
{
    internal class IsExternalInit : Attribute { }
}

// dataキーワードはサンプルソース作成時には機能していない模様である
#if false
public data class Result1
{
    public string FamilyName { get; init; }
    public string FirstName { get; init; }
    public int Point { get; init; }
}

data class Result2 { string FamilyName; string FirstName; int Point; };
#endif

record Result3(string FamilyName, string FirstName, int Point);

class Program
{
    static void Main()
    {
        var r = new Result3("夢野", "サリー", 100);
        Console.WriteLine($"{r.FamilyName}{r.FirstName}は{r.Point}点");
    }
}

using System;

// この定義は将来のバージョンで不要になる見込みである
// エラーになる場合は削除してみると良い
namespace System.Runtime.CompilerServices
{
    internal class IsExternalInit : Attribute { }
}

record Result(string FamilyName, string FirstName, int Point);

class Program
{
    public static void Dump(Result r)
    {
        Console.WriteLine($"{r.FamilyName}{r.FirstName}は{r.Point}点");
    }
    static void Main()
    {
        var r = new Result("田中", "花子", 100);
        Dump(r);
        var r2 = r with { FamilyName = "斉藤" };
        Dump(r2);
        Dump(r);
    }
}

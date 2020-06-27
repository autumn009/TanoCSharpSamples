using System;

//public data class Result
//{
//public string FamilyName { get; init; }
//public string FirstName { get; init; }
//public int Point { get; init; }
//}

//data class User { string FamilyName, string FirstName, int Point};

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

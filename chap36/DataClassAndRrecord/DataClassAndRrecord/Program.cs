using System;

record Result3(string FamilyName, string FirstName, int Point);

class Program
{
    static void Main()
    {
        var r = new Result3("夢野", "サリー", 100);
        Console.WriteLine($"{r.FamilyName}{r.FirstName}は{r.Point}点");
    }
}

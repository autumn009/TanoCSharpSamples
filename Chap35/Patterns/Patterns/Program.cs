using System;

class Sample
{
    public string FamilyName { get; }
    public string FirstName { get; }
    public Sample(string familyName, string firstName) => (FamilyName, FirstName) = (familyName, firstName);
    public void Deconstruct(out string familyName, out string firstName) => (familyName, firstName) = (FamilyName, FirstName);
}

class Program
{
    static void PropertyPatterns(Sample[] ar)
    {
        foreach (var item in ar)
        {
            Console.WriteLine(item switch
            {
                Sample { FamilyName: "山田", FirstName: "太郎" } p => "It's you",
                Sample { FamilyName: var x, FirstName: var y } p => $"You are {x}{y} aren't you?",
                _ => ""
            });
        }
    }

    static void PositionalPatterns(Sample[] ar)
    {
        foreach (var item in ar)
        {
            Console.WriteLine(item switch
            {
                Sample { FamilyName: "山田", FirstName: "太郎" } p => "It's you",
                Sample(var FamilyName, var FirstName) => $"You are {FamilyName}{FirstName} aren't you?",
                _ => ""
            });
        }
    }

    static void TuplePatterns(int x, int y, int z)
    {
        Console.WriteLine((x, y, z) switch
        {
            (8, 1, 3) => "謎",
            (1, 2, 3) when DateTime.Now.Hour >= 12 => "Good Afternoon",
            (1, 2, 3)  => "Good Morning",
            _ => ""
        });
    }

    static void Main()
    {
        Sample[] ar = {
            new Sample("山田", "太郎"),
            new Sample("山田", "花子"),
        };
        PropertyPatterns(ar);
        PositionalPatterns(ar);
        TuplePatterns(1, 2, 3);
        TuplePatterns(8, 1, 3);
    }
}

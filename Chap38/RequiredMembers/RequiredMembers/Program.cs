Person[] persons =
{
    new Person(){ Id="aaa", Name="Alice" },
    new Person(){ Id="bbb" }
};

sub("aaa");
sub("bbb");

void sub(string key)
{
    var person = persons.First(x => x.Id == key);
    Console.WriteLine($"Id={person.Id}");
    Console.WriteLine($"Name={person.Name ?? "unknwon"}");
}

public class Person
{
    public required string Id { get; init; }
    public string? Name { get; init; }
}


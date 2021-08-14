for (int i = 0; i < 2; i++)
{
    var x = new B() { Obj = new A() { Count = i } };
    var r = x switch
    {
        { Obj: { Count: 0 } } => "ZERO",
        { Obj.Count: 1 } => "ONE",
        _ => ""
    };
    Console.WriteLine(r);
}

public class A
{
    public int Count { get; set; }
}
public class B
{
    public A? Obj { get; set; }
}

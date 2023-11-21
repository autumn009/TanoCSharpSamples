var a = new SampleRedord(1);
var b = new SampleClass(2);
var c = new SampleStruct(3);
var d = new SampleClass2(4);
var e = new SampleClass2(5,6);
Console.WriteLine($"a.X={a.X} b.X={b.X} c.X={c.X} d.X={d.X} d.Y={d.Y} e.X={e.X} e.Y={e.Y}");

// recordでプライマリコンストラクタを使う
record SampleRedord(int X);

// classでプライマリコンストラクタを使う
class SampleClass(int x)
{
    public int X { get; } = x;
}

// structでプライマリコンストラクタを使う
struct SampleStruct(int x)
{
    public int X { get; } = x;
}

// プライマリコンストラクタとコンストラクタの併用
class SampleClass2(int x)
{
    public int X { get; } = x;
    public int Y { get; init; } = x;
    public SampleClass2(int x, int y) : this(x) => Y = y;
}


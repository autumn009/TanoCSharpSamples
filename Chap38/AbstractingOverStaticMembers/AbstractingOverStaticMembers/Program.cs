MyInt sumInt = AddAll<MyInt>(new MyInt(3), new MyInt(4), new MyInt(5));
sumInt.Output();
MyLong sumLong = AddAll<MyLong>(new MyLong(3L), new MyLong(4L), new MyLong(5L));
sumLong.Output();

T AddAll<T>(params T[] elements) where T : IMonoid<T>
{
    T result = T.Zero;
    foreach (var element in elements)
    {
        result += element;
    }
    return result;
}
public interface IMonoid<TSelf> where TSelf : IMonoid<TSelf>
{
    public static abstract TSelf operator +(TSelf a, TSelf b);
    public static abstract TSelf Zero { get; }
}
public struct MyInt : IMonoid<MyInt>
{
    private int value;
    public MyInt(int i) => value = i;
    public static MyInt operator +(MyInt a, MyInt b) => new MyInt(a.value + b.value);
    public static MyInt Zero => new MyInt(0);
    public void Output() => Console.WriteLine(value);
}
public struct MyLong : IMonoid<MyLong>
{
    private long value;
    public MyLong(long i) => value = i;
    public static MyLong operator +(MyLong a, MyLong b) => new MyLong(a.value + b.value);
    public static MyLong Zero => new MyLong(0);
    public void Output() => Console.WriteLine(value);
}
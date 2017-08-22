using System;

class Program
{
    #region 通常は使わない実体
    private static int a;
    #endregion
    public static int A { get { return a; } set { a = value; } }
    static void Main(string[] args)
    {
        A = 123;
        Console.WriteLine(A);
    }
}

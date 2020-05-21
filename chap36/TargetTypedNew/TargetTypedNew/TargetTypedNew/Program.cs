using System;

class Program
{
    static void Main()
    {
        // C# 初期のスタイル
        string s1 = new string('A', 10);
        // C# 8までのスタイル
        var s2 = new string('A', 10);
        // C# 9の新しいスタイル
        string s3 = new ('A', 10);

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
    }
}

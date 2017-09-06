using System;

class Program
{
    enum MyPackedBits
    {
        システムは正常に稼働中 = 1,
        データは受付可能 = 2,
        受け取ったデータに色情報が含まれている = 4,
        昨日受け取ったデータがある = 8,
        色 = 16 | 32,
        文字情報は日本語 = 64,
        無効ビット = 127,
        Black = 0 << 4,
        Red = 1 << 4,
        Green = 2 << 4,
        Blue = 3 << 4
    }
    static void Main(string[] args)
    {
        // パックされた数値の作成
        MyPackedBits bits = MyPackedBits.システムは正常に稼働中
            | MyPackedBits.データは受付可能
            | MyPackedBits.受け取ったデータに色情報が含まれている
            | MyPackedBits.Blue
            | MyPackedBits.文字情報は日本語;
        Console.WriteLine("パックされた数値={0}", (int)bits);
        Console.WriteLine();

        // パックされた数値の解読
        if (bits.HasFlag(MyPackedBits.システムは正常に稼働中))
            Console.WriteLine("システムは正常に稼働中");
        if (bits.HasFlag(MyPackedBits.データは受付可能))
            Console.WriteLine("データは受付可能");
        if (bits.HasFlag(MyPackedBits.受け取ったデータに色情報が含まれている))
            Console.WriteLine("受け取ったデータに色情報が含まれている");
        if (bits.HasFlag(MyPackedBits.昨日受け取ったデータがある))
            Console.WriteLine("昨日受け取ったデータがある");
        if (bits.HasFlag(MyPackedBits.文字情報は日本語))
            Console.WriteLine("文字情報は日本語");

        // "/ 16" ではなく ">> 4"でも良い
        int color = (int)(bits & MyPackedBits.色) / 16;
        Console.Write("色={0} ", color);
        switch (color)
        {
            case 0: Console.WriteLine("[黒]"); break;
            case 1: Console.WriteLine("[赤]"); break;
            case 2: Console.WriteLine("[緑]"); break;
            case 3: Console.WriteLine("[青]"); break;
        }
    }
}

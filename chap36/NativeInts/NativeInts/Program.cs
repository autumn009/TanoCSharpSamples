using System;

class Program
{
    static void Main()
    {
        // ↓数値で初期化できない
        IntPtr oldType = new IntPtr(0);
        // ↓数値で初期化できる
        nint newType = 0;

        // ↓できない
        //oldType++;
        // ↓できる
        newType++;

        // ↓できる
        Console.WriteLine(IntPtr.MaxValue);
        // ↓できない
        //Console.WriteLine(nint.MaxValue);

        // 値の型名を教えて
        Console.WriteLine(oldType.GetType().Name);
        Console.WriteLine(newType.GetType().Name);
    }
}

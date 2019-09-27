using System;

public struct SampleStruct1<T>
{
    public T X;
    public T Y;
}

public struct SampleStruct2<T>
{
    public T X;
    public T Y;
    public string Z;
}

class Program
{
    static void Main()
    {
        Span<SampleStruct1<int>> numbers1 = stackalloc SampleStruct1<int>[1];
        // エラー CS0208  マネージ型('SampleStruct2<int>') のアドレスの取得、サイズの取得、またはそのマネージ型へのポインターの宣言が実行できません 
        //Span<SampleStruct2<int>> numbers2 = stackalloc SampleStruct2<int>[1];
    }
}

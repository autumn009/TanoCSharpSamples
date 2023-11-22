var buffer = new CharBuffer();
for (int i = 0; i < 10; i++)
{
    buffer[i] = (char)('a' + i);
}
Console.WriteLine(new string(buffer));

[System.Runtime.CompilerServices.InlineArray(10)]
public struct CharBuffer
{
    private char _firstElement;
}

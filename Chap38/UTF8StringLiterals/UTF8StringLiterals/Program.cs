string a = "The quick brown fox jumps over the lazy dog";
byte[] aBytes = System.Text.Encoding.UTF8.GetBytes(a);
sub(aBytes);

ReadOnlySpan<byte> b = "The quick brown fox jumps over the lazy dog"u8;
sub(b.ToArray());

void sub(byte[] utf8string)
{
    File.WriteAllBytes("thefile.txt",utf8string);
    Console.WriteLine(File.ReadAllText("thefile.txt"));
}

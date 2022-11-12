string s1 = @"
<div>
    <p>
        This is a XML text.
    <p>
</div>
";

string s2 = """
    <div>
        <p>
            This is a XML text.
        <p>
    </div>
    """;

string s3 = """"
    """t1"""
    """t2"""
    """";

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
foreach (var item in s3) Console.Write($"{(int)item} ");
Console.WriteLine();

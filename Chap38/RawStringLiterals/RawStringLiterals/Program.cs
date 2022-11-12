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
    """text"""
    """";

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

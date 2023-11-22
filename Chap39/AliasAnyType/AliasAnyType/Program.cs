using X = int[];
using Y = int[];
X x = { 1, 2, 3 };
sub(x);

void sub(Y y)
{
	foreach (var item in y) Console.WriteLine(item);
}


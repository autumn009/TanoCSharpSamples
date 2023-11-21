int[] a = [1, 2, 3];
sub(a);
sub([4,5,6]);
int[] b = [.. a, 7, 8, 9];
sub(b);
List<int> c = [.. a, .. b, 10, 11, 12];
sub(c);

static void sub(IEnumerable<int> array) => Console.WriteLine(string.Join(',', array));
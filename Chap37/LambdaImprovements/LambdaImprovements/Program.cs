var lambda1 = () => new B();
var lambda2 = A () => new B();
Console.WriteLine(lambda1.GetType().FullName);
Console.WriteLine(lambda2.GetType().FullName);

class A { }
class B : A { }
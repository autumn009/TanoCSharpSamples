using System;
using System.Dynamic;

public class DataStore : DynamicObject
{
    public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
    {
        result = null;
        Console.WriteLine(binder.Name);
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        dynamic dataStore = new DataStore();
        dataStore.HelloWorld();
    }
}

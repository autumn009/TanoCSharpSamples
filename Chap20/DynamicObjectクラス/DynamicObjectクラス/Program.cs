using System;
using System.Collections.Generic;
using System.Dynamic;

public class DataStore : DynamicObject
{
    private Dictionary<string, object> data
                              = new Dictionary<string, object>();

    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
        if (!data.TryGetValue(binder.Name, out result)) result = 0;
        return true;
    }

    public override bool TrySetMember(SetMemberBinder binder, object value)
    {
        data[binder.Name] = value;
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        dynamic dataStore = new DataStore();
        dataStore.C = 123;
        Console.WriteLine("{0}*{1}={2}", dataStore.B, dataStore.C, dataStore.B * dataStore.C);
    }
}

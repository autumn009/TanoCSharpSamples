using System;
using System.Reflection;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        string a = "Hello";
        Type t = a.GetType();
        foreach (MemberInfo item in t.GetMembers())
        {
            if (item.MemberType == MemberTypes.Method)
            {
                var mi = (MethodInfo)item;
                Console.WriteLine("{0}={1} ({2})", mi.MemberType, mi.Name, string.Join(",", mi.GetParameters().Select(c => c.ParameterType)));
            }
            else
                Console.WriteLine("{0}={1}", item.MemberType, item.Name);
        }
    }
}

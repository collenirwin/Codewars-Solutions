using System.Linq;
using System.Reflection;

public static class Reflection
{
  public static string[] GetMethodNames(object TestObject)
  {
    return TestObject != null
      ? TestObject.GetType()
        .GetMethods(BindingFlags.Public |
          BindingFlags.NonPublic |
          BindingFlags.Instance |
          BindingFlags.Static)
        .Select(x => x.Name)
        .ToArray()
      : new string[0];
  }
}
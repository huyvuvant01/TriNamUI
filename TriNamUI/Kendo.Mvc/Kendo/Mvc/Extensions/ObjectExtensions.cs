// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.ObjectExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Kendo.Mvc.Extensions
{
  internal static class ObjectExtensions
  {
    public static IDictionary<string, object> ToDictionary(this object @object)
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>((IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase);
      if (@object != null)
      {
        foreach (PropertyInfo property in @object.GetType().GetProperties())
          dictionary.Add(property.Name.Replace("_", "-"), property.GetValue(@object));
      }
      return (IDictionary<string, object>) dictionary;
    }

    public static IDictionary<string, string> ToStringDictionary(this object @object)
    {
      Dictionary<string, string> dictionary = new Dictionary<string, string>((IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase);
      if (@object != null)
      {
        foreach (PropertyInfo property in @object.GetType().GetProperties())
          dictionary.Add(property.Name, property.GetValue(@object).ToString());
      }
      return (IDictionary<string, string>) dictionary;
    }
  }
}

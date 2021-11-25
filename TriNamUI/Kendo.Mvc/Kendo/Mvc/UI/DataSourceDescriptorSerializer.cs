// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DataSourceDescriptorSerializer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DataSourceDescriptorSerializer
  {
    private const string ColumnDelimiter = "~";

    public static string Serialize<T>(IEnumerable<T> descriptors) where T : IDescriptor => !descriptors.Any<T>() ? "~" : string.Join("~", descriptors.Select<T, string>((Func<T, string>) (d => d.Serialize())).ToArray<string>());

    public static IList<T> Deserialize<T>(string from) where T : IDescriptor, new()
    {
      List<T> objList = new List<T>();
      if (!from.HasValue())
        return (IList<T>) objList;
      foreach (string source in from.Split("~".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
      {
        T obj = new T();
        obj.Deserialize(source);
        objList.Add(obj);
      }
      return (IList<T>) objList;
    }
  }
}

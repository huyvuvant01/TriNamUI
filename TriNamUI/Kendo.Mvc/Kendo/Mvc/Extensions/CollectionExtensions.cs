// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.CollectionExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.Extensions
{
  public static class CollectionExtensions
  {
    public static void AddRange<T>(this ICollection<T> instance, IEnumerable<T> collection)
    {
      foreach (T obj in collection)
        instance.Add(obj);
    }
  }
}

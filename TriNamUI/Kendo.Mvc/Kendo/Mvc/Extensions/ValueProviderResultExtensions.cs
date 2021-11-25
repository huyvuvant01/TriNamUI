// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.ValueProviderResultExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Primitives;
using System;

namespace Kendo.Mvc.Extensions
{
  public static class ValueProviderResultExtensions
  {
    internal static T ConvertValueTo<T>(this ValueProviderResult result)
    {
      object obj = (object) null;
      if (result.Values.Count == 1)
        obj = (object) result.FirstValue;
      else if (result.Values.Count > 1)
        obj = (object) result.Values.ToArray();
      return ModelBindingHelper.ConvertTo<T>(obj, result.Culture);
    }

    public static object ConvertValueTo(this ValueProviderResult result, Type type)
    {
      if (type == (Type) null)
        throw new ArgumentNullException(nameof (type));
      object obj1 = (object) null;
      if (result.Values.Count == 1)
      {
        obj1 = (object) result.FirstValue;
      }
      else
      {
        StringValues values = result.Values;
        if (values.Count > 1)
        {
          values = result.Values;
          obj1 = (object) values.ToArray();
        }
      }
      object obj2 = (object) null;
      try
      {
        obj2 = ModelBindingHelper.ConvertTo(obj1, type, result.Culture);
      }
      catch
      {
      }
      return obj2;
    }
  }
}

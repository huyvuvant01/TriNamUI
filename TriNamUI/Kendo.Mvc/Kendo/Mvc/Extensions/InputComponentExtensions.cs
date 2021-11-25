// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.InputComponentExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace Kendo.Mvc.Extensions
{
  public static class InputComponentExtensions
  {
    public static T? GetValue<T>(this IInputComponent<T> instance, Func<object, T?> converter) where T : struct
    {
      T? nullable = new T?();
      object obj = instance.ViewContext.ViewData.Eval(instance.Name);
      if (instance.Value.HasValue)
        nullable = instance.Value;
      else if (obj != null)
        nullable = converter(obj);
      instance.Value = nullable;
      return nullable;
    }

    public static string GetAttemptedValue<T>(this IInputComponent<T> instance) where T : struct => (string) instance.GetModelStateValue<T>(instance.Name, typeof (string));

    internal static object GetModelStateValue<T>(
      this IInputComponent<T> instance,
      string key,
      Type destinationType)
      where T : struct
    {
      ModelStateEntry modelStateEntry;
      return instance.ViewContext.ViewData.ModelState.TryGetValue(key, out modelStateEntry) && modelStateEntry.RawValue != null ? Convert.ChangeType(modelStateEntry.RawValue, destinationType) : (object) null;
    }
  }
}

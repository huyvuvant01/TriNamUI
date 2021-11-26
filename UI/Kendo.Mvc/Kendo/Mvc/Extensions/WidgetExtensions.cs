// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.WidgetExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;

namespace Kendo.Mvc.Extensions
{
  public static class WidgetExtensions
  {
    public static string GetValue<T>(this IWidget instance, T value) => instance.GetValue<T>(instance.Name, value);

    public static string GetValue<T>(this IWidget instance, string name, T value, string format = "{0}")
    {
      string str = string.Empty;
      ViewDataDictionary viewData = instance.ViewContext.ViewData;
      object obj = name.HasValue() ? viewData.Eval(name) : (object) null;
      ModelStateEntry modelStateEntry;
      if (name.HasValue() && viewData.ModelState.TryGetValue(name, out modelStateEntry) && modelStateEntry.RawValue != null)
      {
        str = modelStateEntry.AttemptedValue;
        if (viewData.ModelState.GetFieldValidationState(name) == ModelValidationState.Valid)
          str = format.FormatWith(Convert.ChangeType(modelStateEntry.RawValue, typeof (T)));
      }
      else if ((object) value != null)
        str = format.FormatWith((object) value);
      else if (obj != null && obj.GetType().IsPredefinedType())
        str = format.FormatWith(obj);
      return str;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.RouteValueDictionaryExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.Extensions
{
  public static class RouteValueDictionaryExtensions
  {
    private static void GetActionParams(
      RouteValueDictionary routeValues,
      out object actionName,
      out object controllerName,
      RouteValueDictionary values)
    {
      routeValues.TryGetValue("action", out actionName);
      routeValues.TryGetValue("controller", out controllerName);
      routeValues.Remove("action");
      routeValues.Remove("controller");
      DictionaryExtensions.Merge(values, (IDictionary<string, object>) routeValues);
    }

    public static void ApplyTo(
      this RouteValueDictionary routeValues,
      INavigatable instance,
      Action<INavigatable, string, string, RouteValueDictionary> callBack)
    {
      RouteValueDictionary values = new RouteValueDictionary();
      object actionName;
      object controllerName;
      RouteValueDictionaryExtensions.GetActionParams(routeValues, out actionName, out controllerName, values);
      callBack(instance, (string) actionName, (string) controllerName, values);
    }

    public static TBuilder ApplyTo<TBuilder>(
      this RouteValueDictionary routeValues,
      Func<string, string, RouteValueDictionary, TBuilder> callBack)
    {
      RouteValueDictionary values = new RouteValueDictionary();
      object actionName;
      object controllerName;
      RouteValueDictionaryExtensions.GetActionParams(routeValues, out actionName, out controllerName, values);
      return callBack((string) actionName, (string) controllerName, values);
    }
  }
}

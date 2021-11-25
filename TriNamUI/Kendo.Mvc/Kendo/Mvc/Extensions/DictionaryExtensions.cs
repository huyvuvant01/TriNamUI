// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.DictionaryExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.Extensions
{
  public static class DictionaryExtensions
  {
    public static void Merge(
      this IDictionary<string, object> instance,
      string key,
      object value,
      bool replaceExisting)
    {
      if (!replaceExisting && instance.ContainsKey(key))
        return;
      instance[key] = value;
    }

    public static void AppendInValue(
      this IDictionary<string, object> instance,
      string key,
      string separator,
      object value)
    {
      instance[key] = instance.ContainsKey(key) ? (object) (instance[key]?.ToString() + separator + value?.ToString()) : (object) value.ToString();
    }

    public static void PrependInValue(
      this IDictionary<string, object> instance,
      string key,
      string separator,
      object value)
    {
      instance[key] = instance.ContainsKey(key) ? (object) (value?.ToString() + separator + instance[key]?.ToString()) : (object) value.ToString();
    }

    public static void Merge(
      this IDictionary<string, object> instance,
      IDictionary<string, object> from,
      bool replaceExisting)
    {
      foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) from)
      {
        if (replaceExisting || !instance.ContainsKey(keyValuePair.Key))
          instance[keyValuePair.Key] = keyValuePair.Value;
      }
    }

    public static void Merge(
      this IDictionary<string, object> instance,
      IDictionary<string, object> from)
    {
      DictionaryExtensions.Merge(instance, from, true);
    }

    public static void Merge(
      this IDictionary<string, object> instance,
      object values,
      bool replaceExisting)
    {
      DictionaryExtensions.Merge(instance, (IDictionary<string, object>) new RouteValueDictionary(values), replaceExisting);
    }

    public static void Merge(this IDictionary<string, object> instance, object values) => instance.Merge(values, true);

    public static IDictionary<string, object> Add<T>(
      this IDictionary<string, object> instance,
      string key,
      T value,
      T defaultValue)
      where T : IComparable
    {
      if ((object) value != null && value.CompareTo((object) defaultValue) != 0)
        instance[key] = (object) value;
      return instance;
    }

    public static IDictionary<string, object> Add<T>(
      this IDictionary<string, object> instance,
      string key,
      T value,
      Func<bool> condition)
    {
      if (condition())
        instance[key] = (object) value;
      return instance;
    }

    public static string ToAttributeString(this IDictionary<string, object> instance)
    {
      StringBuilder stringBuilder = new StringBuilder();
      HtmlEncoder htmlEncoder = HtmlEncoder.Default;
      foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) instance)
        stringBuilder.Append(" {0}=\"{1}\"".FormatWith((object) htmlEncoder.Encode(keyValuePair.Key), (object) htmlEncoder.Encode(keyValuePair.Value.ToString())));
      return stringBuilder.ToString();
    }
  }
}

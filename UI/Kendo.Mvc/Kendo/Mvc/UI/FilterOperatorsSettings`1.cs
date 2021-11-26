// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FilterOperatorsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class FilterOperatorsSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public FilterOperatorsStringSettings<T> String { get; } = new FilterOperatorsStringSettings<T>();

    public FilterOperatorsNumberSettings<T> Number { get; } = new FilterOperatorsNumberSettings<T>();

    public FilterOperatorsDateSettings<T> Date { get; } = new FilterOperatorsDateSettings<T>();

    public FilterOperatorsBooleanSettings<T> Boolean { get; } = new FilterOperatorsBooleanSettings<T>();

    public Kendo.Mvc.UI.Filter<T> Filter { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.String.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["string"] = (object) source1;
      Dictionary<string, object> source2 = this.Number.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["number"] = (object) source2;
      Dictionary<string, object> source3 = this.Date.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["date"] = (object) source3;
      Dictionary<string, object> source4 = this.Boolean.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["boolean"] = (object) source4;
      return dictionary;
    }
  }
}

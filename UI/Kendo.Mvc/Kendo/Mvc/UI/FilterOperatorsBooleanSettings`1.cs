// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FilterOperatorsBooleanSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class FilterOperatorsBooleanSettings<T> : OperatorsBase where T : class
  {
    public FilterOperatorsBooleanSettings() => this.Operators = (IDictionary<string, string>) new Dictionary<string, string>();

    public CustomOperatorSettings Custom { get; } = new CustomOperatorSettings();

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      this.Serialize((IDictionary<string, object>) dictionary);
      Dictionary<string, object> source = this.Custom.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary[this.Custom.Name] = (object) source;
      return dictionary;
    }

    public Kendo.Mvc.UI.Filter<T> Filter { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      foreach (KeyValuePair<string, string> keyValuePair in (IEnumerable<KeyValuePair<string, string>>) this.Operators)
        json[keyValuePair.Key] = (object) keyValuePair.Value;
    }
  }
}

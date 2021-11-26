// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesStackSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ChartSeriesStackSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Group { get; set; }

    public ChartStackType? Type { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string group = this.Group;
      if ((group != null ? (group.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["group"] = (object) this.Group;
      ChartStackType? type = this.Type;
      if (type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        type = this.Type;
        ref ChartStackType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}

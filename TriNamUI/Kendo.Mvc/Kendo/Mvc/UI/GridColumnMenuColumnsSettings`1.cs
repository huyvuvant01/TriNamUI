// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridColumnMenuColumnsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GridColumnMenuColumnsSettings<T> where T : class
  {
    public List<GridColumnMenuColumnsSettingsGroup<T>> Groups { get; set; } = new List<GridColumnMenuColumnsSettingsGroup<T>>();

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IEnumerable<Dictionary<string, object>> source = this.Groups.Select<GridColumnMenuColumnsSettingsGroup<T>, Dictionary<string, object>>((Func<GridColumnMenuColumnsSettingsGroup<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["groups"] = (object) source;
      return dictionary;
    }

    public string Sort { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.Grid<T> Grid { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string sort = this.Sort;
      if ((sort != null ? (sort.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sort"] = (object) this.Sort;
      return dictionary;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridColumnMenuSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GridColumnMenuSettings<T> where T : class
  {
    public GridColumnMenuMessages Messages { get; } = new GridColumnMenuMessages();

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IDictionary<string, object> source = this.Messages.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
      {
        bool? enabled = this.Enabled;
        bool flag = true;
        if (enabled.GetValueOrDefault() == flag & enabled.HasValue)
          dictionary["messages"] = (object) source;
      }
      return dictionary;
    }

    public GridColumnMenuColumnsSettings<T> Columns { get; } = new GridColumnMenuColumnsSettings<T>();

    public bool? Filterable { get; set; }

    public string ComponentType { get; set; }

    public bool? Sortable { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.Grid<T> Grid { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source = this.Columns.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["columns"] = (object) source;
      else if (this.Columns.Enabled.HasValue)
        dictionary["columns"] = (object) this.Columns.Enabled;
      if (this.Filterable.HasValue)
        dictionary["filterable"] = (object) this.Filterable;
      string componentType = this.ComponentType;
      if ((componentType != null ? (componentType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["componentType"] = (object) this.ComponentType;
      if (this.Sortable.HasValue)
        dictionary["sortable"] = (object) this.Sortable;
      return dictionary;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListColumnMenuSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TreeListColumnMenuSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Columns { get; set; }

    public bool? Filterable { get; set; }

    public bool? Sortable { get; set; }

    public TreeListColumnMenuMessagesSettings<T> Messages { get; } = new TreeListColumnMenuMessagesSettings<T>();

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Columns.HasValue)
        dictionary["columns"] = (object) this.Columns;
      if (this.Filterable.HasValue)
        dictionary["filterable"] = (object) this.Filterable;
      if (this.Sortable.HasValue)
        dictionary["sortable"] = (object) this.Sortable;
      Dictionary<string, object> source = this.Messages.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source;
      return dictionary;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridColumnMenuColumnsSettingsGroup`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GridColumnMenuColumnsSettingsGroup<T> where T : class
  {
    public GridColumnMenuColumnsSettingsGroup() => this.Columns = (IEnumerable<string>) new List<string>();

    public Kendo.Mvc.UI.Grid<T> Grid { get; set; }

    public string Title { get; set; }

    public IEnumerable<string> Columns { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Columns.Any<string>())
        dictionary["columns"] = (object) this.Columns;
      if (!string.IsNullOrEmpty(this.Title))
        dictionary["title"] = (object) this.Title;
      return dictionary;
    }
  }
}

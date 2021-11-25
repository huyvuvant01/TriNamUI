// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SpreadsheetSheetRow
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class SpreadsheetSheetRow
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public List<SpreadsheetSheetRowCell> Cells { get; set; } = new List<SpreadsheetSheetRowCell>();

    public double? Height { get; set; }

    public int? Index { get; set; }

    public string Type { get; set; }

    public Spreadsheet Spreadsheet { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IEnumerable<Dictionary<string, object>> source = this.Cells.Select<SpreadsheetSheetRowCell, Dictionary<string, object>>((Func<SpreadsheetSheetRowCell, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["cells"] = (object) source;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      if (this.Index.HasValue)
        dictionary["index"] = (object) this.Index;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      return dictionary;
    }
  }
}

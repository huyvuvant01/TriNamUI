// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SpreadsheetSheetFilterSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class SpreadsheetSheetFilterSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public List<SpreadsheetSheetFilterSettingsColumn> Columns { get; set; } = new List<SpreadsheetSheetFilterSettingsColumn>();

    public string Ref { get; set; }

    public Spreadsheet Spreadsheet { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IEnumerable<Dictionary<string, object>> source = this.Columns.Select<SpreadsheetSheetFilterSettingsColumn, Dictionary<string, object>>((Func<SpreadsheetSheetFilterSettingsColumn, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["columns"] = (object) source;
      string str = this.Ref;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["ref"] = (object) this.Ref;
      return dictionary;
    }
  }
}

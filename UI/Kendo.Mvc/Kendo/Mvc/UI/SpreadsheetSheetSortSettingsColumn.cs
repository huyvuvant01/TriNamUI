// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SpreadsheetSheetSortSettingsColumn
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SpreadsheetSheetSortSettingsColumn
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Ascending { get; set; }

    public double? Index { get; set; }

    public Spreadsheet Spreadsheet { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Ascending.HasValue)
        dictionary["ascending"] = (object) this.Ascending;
      if (this.Index.HasValue)
        dictionary["index"] = (object) this.Index;
      return dictionary;
    }
  }
}

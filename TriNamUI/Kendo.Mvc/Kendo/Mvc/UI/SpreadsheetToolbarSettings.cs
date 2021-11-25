// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SpreadsheetToolbarSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class SpreadsheetToolbarSettings
  {
    public SpreadsheetToolbarSettings()
    {
      this.Enabled = new bool?(true);
      this.Home = new SpreadsheetToolTab();
      this.Insert = new SpreadsheetToolTab();
      this.Data = new SpreadsheetToolTab();
      new SpreadsheetToolFactory(this.Home).Open().ExportAs().Group((Action<SpreadsheetGroupedToolFactory>) (g => g.Cut().Copy().Paste())).Group((Action<SpreadsheetGroupedToolFactory>) (g => g.Bold().Italic().Underline())).Hyperlink().InsertComment().InsertImage().BackgroundColor().TextColor().Borders().FontSize().FontFamily().Alignment().TextWrap().Group((Action<SpreadsheetGroupedToolFactory>) (g => g.FormatDecreaseDecimal().FormatIncreaseDecimal())).Format().Merge().Freeze().Filter().ToggleGridLines();
      new SpreadsheetToolFactory(this.Insert).Group((Action<SpreadsheetGroupedToolFactory>) (g => g.AddColumnLeft().AddColumnRight().AddRowBelow().AddRowAbove())).Group((Action<SpreadsheetGroupedToolFactory>) (g => g.DeleteColumn().DeleteRow()));
      new SpreadsheetToolFactory(this.Data).Sort().Filter().Validation();
    }

    public bool? Enabled { get; set; }

    public Spreadsheet Spreadsheet { get; set; }

    public SpreadsheetToolTab Home { get; set; }

    public SpreadsheetToolTab Insert { get; set; }

    public SpreadsheetToolTab Data { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      dictionary["home"] = (object) this.Home.Enabled;
      dictionary["insert"] = (object) this.Insert.Enabled;
      dictionary["data"] = (object) this.Data.Enabled;
      if (this.Home.Enabled && this.Home.Tools.Any<SpreadsheetTool>())
        dictionary["home"] = (object) this.Home.Tools.Select<SpreadsheetTool, object>((Func<SpreadsheetTool, object>) (tool => tool.ToJson()[nameof (tool)]));
      if (this.Insert.Enabled && this.Insert.Tools.Any<SpreadsheetTool>())
        dictionary["insert"] = (object) this.Insert.Tools.Select<SpreadsheetTool, object>((Func<SpreadsheetTool, object>) (tool => tool.ToJson()[nameof (tool)]));
      if (this.Data.Enabled && this.Data.Tools.Any<SpreadsheetTool>())
        dictionary["data"] = (object) this.Data.Tools.Select<SpreadsheetTool, object>((Func<SpreadsheetTool, object>) (tool => tool.ToJson()[nameof (tool)]));
      return dictionary;
    }
  }
}

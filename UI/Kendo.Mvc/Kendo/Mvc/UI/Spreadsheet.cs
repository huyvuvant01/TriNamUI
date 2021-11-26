// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Spreadsheet
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Spreadsheet : WidgetBase
  {
    internal Dictionary<string, object> DplSettings { get; set; }

    public Spreadsheet(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public object Images { get; set; }

    public SpreadsheetToolbarSettings Toolbar { get; } = new SpreadsheetToolbarSettings();

    protected override void WriteHtml(TextWriter writer)
    {
      this.HtmlAttributes.Merge("data-role", (object) "spreadsheet", true);
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> instance = this.SerializeSettings();
      if (this.DplSettings != null)
        DictionaryExtensions.Merge(instance, (IDictionary<string, object>) this.DplSettings);
      if (this.Images != null)
        instance["images"] = this.Images;
      Dictionary<string, object> source = this.Toolbar.Serialize();
      bool? enabled = this.Toolbar.Enabled;
      bool flag = false;
      if (enabled.GetValueOrDefault() == flag & enabled.HasValue)
        instance["toolbar"] = (object) this.Toolbar.Enabled;
      else if (source.Any<KeyValuePair<string, object>>())
        instance["toolbar"] = (object) source;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Spreadsheet), (IDictionary<string, object>) instance));
    }

    public string ActiveSheet { get; set; }

    public double? ColumnWidth { get; set; }

    public double? Columns { get; set; }

    public SpreadsheetDefaultCellStyleSettings DefaultCellStyle { get; } = new SpreadsheetDefaultCellStyleSettings();

    public double? HeaderHeight { get; set; }

    public double? HeaderWidth { get; set; }

    public SpreadsheetExcelSettings Excel { get; } = new SpreadsheetExcelSettings();

    public SpreadsheetPdfSettings Pdf { get; } = new SpreadsheetPdfSettings();

    public double? RowHeight { get; set; }

    public double? Rows { get; set; }

    public List<SpreadsheetSheet> Sheets { get; set; } = new List<SpreadsheetSheet>();

    public bool? Sheetsbar { get; set; }

    public bool? UseCultureDecimals { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      string activeSheet = this.ActiveSheet;
      if ((activeSheet != null ? (activeSheet.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activeSheet"] = (object) this.ActiveSheet;
      double? nullable1 = this.ColumnWidth;
      if (nullable1.HasValue)
        dictionary["columnWidth"] = (object) this.ColumnWidth;
      nullable1 = this.Columns;
      if (nullable1.HasValue)
        dictionary["columns"] = (object) this.Columns;
      Dictionary<string, object> source1 = this.DefaultCellStyle.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["defaultCellStyle"] = (object) source1;
      nullable1 = this.HeaderHeight;
      if (nullable1.HasValue)
        dictionary["headerHeight"] = (object) this.HeaderHeight;
      nullable1 = this.HeaderWidth;
      if (nullable1.HasValue)
        dictionary["headerWidth"] = (object) this.HeaderWidth;
      Dictionary<string, object> source2 = this.Excel.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["excel"] = (object) source2;
      Dictionary<string, object> source3 = this.Pdf.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["pdf"] = (object) source3;
      nullable1 = this.RowHeight;
      if (nullable1.HasValue)
        dictionary["rowHeight"] = (object) this.RowHeight;
      nullable1 = this.Rows;
      if (nullable1.HasValue)
        dictionary["rows"] = (object) this.Rows;
      IEnumerable<Dictionary<string, object>> source4 = this.Sheets.Select<SpreadsheetSheet, Dictionary<string, object>>((Func<SpreadsheetSheet, Dictionary<string, object>>) (i => i.Serialize()));
      if (source4.Any<Dictionary<string, object>>())
        dictionary["sheets"] = (object) source4;
      bool? nullable2 = this.Sheetsbar;
      if (nullable2.HasValue)
        dictionary["sheetsbar"] = (object) this.Sheetsbar;
      nullable2 = this.UseCultureDecimals;
      if (nullable2.HasValue)
        dictionary["useCultureDecimals"] = (object) this.UseCultureDecimals;
      return dictionary;
    }
  }
}

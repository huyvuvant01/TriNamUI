// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetSheetTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("sheet", ParentTag = "sheets", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("columns", new string[] {"filter", "rows", "sort", "datasource"})]
  [SuppressTagRendering]
  public class SpreadsheetSheetTagHelper : 
    TagHelperCollectionItemBase,
    IDataBoundWidget<
    #nullable disable
    DataSourceTagHelper>
  {
    [HtmlAttributeNotBound]
    public DataSourceTagHelper Datasource { get; set; }

    public string[] MergedCells { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SpreadsheetSheetsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SpreadsheetSheetsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      if (this.MergedCells != null && this.MergedCells.Length != 0)
        dictionary["mergedCells"] = (object) this.MergedCells;
      return dictionary;
    }

    public string ActiveCell { get; set; }

    public string Name { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetColumnsTagHelper Columns { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetDrawingsTagHelper Drawings { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetFilterSettingsTagHelper Filter { get; set; }

    public double? FrozenColumns { get; set; }

    public double? FrozenRows { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetRowsTagHelper Rows { get; set; }

    public string Selection { get; set; }

    public bool? ShowGridLines { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetSortSettingsTagHelper Sort { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string activeCell = this.ActiveCell;
      if ((activeCell != null ? (activeCell.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activeCell"] = (object) this.ActiveCell;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      if (this.Columns != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Columns.Select<SpreadsheetSheetColumnTagHelper, Dictionary<string, object>>((Func<SpreadsheetSheetColumnTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["columns"] = (object) source;
      }
      if (this.Drawings != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Drawings.Select<SpreadsheetSheetDrawingTagHelper, Dictionary<string, object>>((Func<SpreadsheetSheetDrawingTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["drawings"] = (object) source;
      }
      if (this.Filter != null)
      {
        Dictionary<string, object> source = this.Filter.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["filter"] = (object) source;
      }
      double? nullable = this.FrozenColumns;
      if (nullable.HasValue)
        dictionary["frozenColumns"] = (object) this.FrozenColumns;
      nullable = this.FrozenRows;
      if (nullable.HasValue)
        dictionary["frozenRows"] = (object) this.FrozenRows;
      if (this.Rows != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Rows.Select<SpreadsheetSheetRowTagHelper, Dictionary<string, object>>((Func<SpreadsheetSheetRowTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["rows"] = (object) source;
      }
      string selection = this.Selection;
      if ((selection != null ? (selection.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selection"] = (object) this.Selection;
      if (this.ShowGridLines.HasValue)
        dictionary["showGridLines"] = (object) this.ShowGridLines;
      if (this.Sort != null)
      {
        Dictionary<string, object> source = this.Sort.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["sort"] = (object) source;
      }
      return dictionary;
    }
  }
}
